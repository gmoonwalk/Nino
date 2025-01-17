/* this is generated by nino */
namespace Nino.Benchmark.Models
{
    public partial class Data
    {
        public static Data.SerializationHelper NinoSerializationHelper = new Data.SerializationHelper();
        public class SerializationHelper: Nino.Serialization.NinoWrapperBase<Data>
        {
            #region NINO_CODEGEN
            public override void Serialize(Data value, Nino.Serialization.Writer writer)
            {
                if(value == null)
                {
                    writer.Write(false);
                    return;
                }
                writer.Write(true);
                writer.CompressAndWrite(ref value.X);
                writer.Write(value.Y);
                writer.CompressAndWrite(ref value.Z);
                writer.Write(value.F);
                writer.Write(value.D);
                writer.Write(value.Db);
                writer.Write(value.Bo);
                writer.CompressAndWriteEnum<Nino.Benchmark.Models.TestEnum>(value.En);
                writer.Write(value.Name);
            }

            public override Data Deserialize(Nino.Serialization.Reader reader)
            {
                if(!reader.ReadBool())
                    return null;
                Data value = new Data();
                reader.DecompressAndReadNumber<System.Int32>(ref value.X);
                reader.Read<System.Int16>(ref value.Y, Nino.Shared.Mgr.ConstMgr.SizeOfShort);
                reader.DecompressAndReadNumber<System.Int64>(ref value.Z);
                reader.Read<System.Single>(ref value.F, Nino.Shared.Mgr.ConstMgr.SizeOfUInt);
                reader.Read<System.Decimal>(ref value.D, Nino.Shared.Mgr.ConstMgr.SizeOfDecimal);
                reader.Read<System.Double>(ref value.Db, Nino.Shared.Mgr.ConstMgr.SizeOfULong);
                reader.Read<System.Boolean>(ref value.Bo, 1);
                reader.DecompressAndReadEnum<Nino.Benchmark.Models.TestEnum>(ref value.En);
                value.Name = reader.ReadString();
                return value;
            }
            #endregion
        }
    }
}