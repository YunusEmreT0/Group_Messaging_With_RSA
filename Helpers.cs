using Net.Pkcs11Interop.Common;
using Net.Pkcs11Interop.HighLevelAPI;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GroupMessage
{
    internal class Helpers
    {
        private const string txtpath = @"C:\Yunus\Visual Studio 2022\GroupMessage\bin\Debug\net6.0-windows\Text\";
        public const string sqlConnPath = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GroupMessageDB";
        private const string pkcs11Path = @"C:\SoftHSM2\lib\softhsm2-x64.dll";

        public static string MD5Encrypter(string plainText)
        {
            MD5 md5 = MD5.Create();
            string chiperText = Encoding.UTF8.GetString(md5.ComputeHash(Encoding.UTF8.GetBytes(plainText)));
            return chiperText;
        }
        public static void SqlInserter(string sql, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = cmd;
            adapter.InsertCommand.ExecuteNonQuery();
        }
        public static void Pkcs11TokenGenerater(string soPin, string label)
        {
            Pkcs11InteropFactories factories = new Pkcs11InteropFactories();
            using (IPkcs11Library pk11 = factories.Pkcs11LibraryFactory.LoadPkcs11Library(factories, pkcs11Path, AppType.MultiThreaded))
            {
                var slot = pk11.GetSlotList(SlotsType.WithOrWithoutTokenPresent).FirstOrDefault(x => x.GetTokenInfo().TokenFlags.TokenInitialized == false);
                slot.InitToken(soPin, label);
            }
        }
        public static void Pkcs11RSAKeyGenerator(string soPin, string label)
        {
            Pkcs11InteropFactories factories = new Pkcs11InteropFactories();
            using (IPkcs11Library pk11 = factories.Pkcs11LibraryFactory.LoadPkcs11Library(factories, pkcs11Path, AppType.MultiThreaded))
            {
                var slot = pk11.GetSlotList(SlotsType.WithTokenPresent).FirstOrDefault(x => x.GetTokenInfo().Label == label);
                using (var session = slot.OpenSession(SessionType.ReadWrite))
                {
                    session.Login(CKU.CKU_SO, soPin);
                    session.InitPin(soPin);
                    session.Logout();
                    session.Login(CKU.CKU_USER, soPin);

                    List<IObjectAttribute> objectAttributesPrivate = new List<IObjectAttribute>();
                    objectAttributesPrivate.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_CLASS, CKO.CKO_PRIVATE_KEY));
                    objectAttributesPrivate.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_KEY_TYPE, CKK.CKK_RSA));
                    objectAttributesPrivate.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_PRIVATE, true));
                    objectAttributesPrivate.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_MODIFIABLE, true));
                    objectAttributesPrivate.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_DECRYPT, true));
                    objectAttributesPrivate.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_LABEL, "Private"));
                    objectAttributesPrivate.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_TOKEN, true));
                    objectAttributesPrivate.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_SIGN, true));
                    objectAttributesPrivate.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_ID, 1));
                    objectAttributesPrivate.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_SENSITIVE, true));
                    objectAttributesPrivate.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_SIGN, true));
                    objectAttributesPrivate.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_SIGN_RECOVER, true));
                    objectAttributesPrivate.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_UNWRAP, true));

                    List<IObjectAttribute> objectAttributesPublic = new List<IObjectAttribute>();
                    objectAttributesPublic.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_CLASS, CKO.CKO_PUBLIC_KEY));
                    objectAttributesPublic.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_TOKEN, true));
                    objectAttributesPublic.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_KEY_TYPE, CKK.CKK_RSA));
                    objectAttributesPublic.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_PRIVATE, false));
                    objectAttributesPublic.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_MODIFIABLE, true));
                    objectAttributesPublic.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_ENCRYPT, true));
                    objectAttributesPublic.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_LABEL, "Public"));
                    objectAttributesPublic.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_VERIFY, true));
                    objectAttributesPublic.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_ID, 1));
                    objectAttributesPublic.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_VERIFY_RECOVER, true));
                    objectAttributesPublic.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_WRAP, true));
                    objectAttributesPublic.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_MODULUS_BITS, 1024));
                    objectAttributesPublic.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_PUBLIC_EXPONENT, new byte[] { 0x01, 0x00, 0x01 }));

                    IMechanism mc = session.Factories.MechanismFactory.Create(CKM.CKM_RSA_PKCS_KEY_PAIR_GEN);
                    IObjectHandle pri, pub;
                    session.GenerateKeyPair(mc, objectAttributesPublic, objectAttributesPrivate, out pub, out pri);
                    session.Logout();
                }
            }
        }
        public static SqlDataReader SqlReader(string sql, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            return cmd.ExecuteReader();
        }
        public static void Pkcs11RSAEncrypter(string label, string data, string fileName)
        {
            Pkcs11InteropFactories factories = new Pkcs11InteropFactories();
            using (IPkcs11Library pk11 = factories.Pkcs11LibraryFactory.LoadPkcs11Library(factories, pkcs11Path, AppType.MultiThreaded))
            {
                var slot = pk11.GetSlotList(SlotsType.WithTokenPresent).FirstOrDefault(x => x.GetTokenInfo().Label == label);
                using (ISession session = slot.OpenSession(SessionType.ReadWrite))
                {
                    List<IObjectAttribute> objectAttributes = new List<IObjectAttribute>();
                    objectAttributes.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_CLASS, CKO.CKO_PUBLIC_KEY));
                    objectAttributes.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_LABEL, "Public"));

                    session.FindObjectsInit(objectAttributes);
                    List<IObjectHandle> foundObjects = session.FindObjects(1);
                    session.FindObjectsFinal();

                    IMechanism mechanism = session.Factories.MechanismFactory.Create(CKM.CKM_RSA_PKCS);

                    byte[] src = Encoding.UTF8.GetBytes(data);
                    byte[] enc = session.Encrypt(mechanism, foundObjects[0], src);

                    FileStream fs = new FileStream(txtpath + fileName + ".txt", FileMode.Create, FileAccess.Write);
                    fs.Write(enc, 0, enc.Length);
                    fs.Close();
                }
            }
        }
        public static string Pkcs11RSADecrypter(string label, string password, List<string> filenames, int index)
        {
            string result = "";

            Pkcs11InteropFactories factories = new Pkcs11InteropFactories();
            using (IPkcs11Library pk11 = factories.Pkcs11LibraryFactory.LoadPkcs11Library(factories, pkcs11Path, AppType.MultiThreaded))
            {
                var slot = pk11.GetSlotList(SlotsType.WithTokenPresent).FirstOrDefault(x => x.GetTokenInfo().Label == label);
                using (ISession session = slot.OpenSession(SessionType.ReadWrite))
                {
                    session.Login(CKU.CKU_USER, password);

                    List<IObjectAttribute> objectAttributes = new List<IObjectAttribute>();
                    objectAttributes.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_CLASS, CKO.CKO_PRIVATE_KEY));
                    objectAttributes.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_LABEL, "Private"));

                    session.FindObjectsInit(objectAttributes);
                    List<IObjectHandle> foundObjects = session.FindObjects(1);
                    session.FindObjectsFinal();

                    IMechanism mechanism = session.Factories.MechanismFactory.Create(CKM.CKM_RSA_PKCS);

                    try
                    {
                        FileStream fs = new FileStream(txtpath + filenames[index], FileMode.Open, FileAccess.Read);
                        byte[] buffer = new byte[fs.Length];
                        fs.Read(buffer, 0, buffer.Length);

                        byte[] dec = session.Decrypt(mechanism, foundObjects[0], buffer);
                        result = Encoding.UTF8.GetString(dec);
                    }
                    catch (Exception ex)
                    {
                        result = ex.Message;
                    }
                    session.Logout();
                }
            }
            return result;
        }
    }
}