// Generated by github.com/davyxu/protoplus
// DO NOT EDIT!
using System;
using System.Collections.Generic;
using ProtoPlus;

namespace Proto
{
	
	public enum MyEnum 
	{
		
		Zero = 0, 
		One = 1, 
		Two = 2, 
	} 
	
	
	public partial class MyTypeMini : IProtoStruct 
	{
		public string Str;
		public bool Bool;
		
		#region Serialize Code
		public void Init( )
		{   
 			  
		}

		public void Marshal(OutputStream stream)
		{  
			stream.WriteString(1, Str );  
			stream.WriteBool(2, Bool ); 
		}

		public int GetSize()
		{
			int size = 0;  
			size += OutputStream.SizeString(1, Str);  
			size += OutputStream.SizeBool(2, Bool); 
			return size;
		}

 		public bool Unmarshal(InputStream stream, int fieldNumber, WireFormat.WireType wt)
		{
		 	switch (fieldNumber)
            { 
			case 1:	
				stream.ReadString(wt, ref Str);
                break; 
			case 2:	
				stream.ReadBool(wt, ref Bool);
                break; 
			default:
				return true;
            }

            return false;
		}
		#endregion
	}

	
	public partial class MySubType : IProtoStruct 
	{
		public bool Bool;
		public int Int32;
		public uint UInt32;
		public long Int64;
		public ulong UInt64;
		public float Float32;
		public double Float64;
		public string Str;
		public byte[] BytesSlice;
		public List<bool> BoolSlice;
		public List<int> Int32Slice;
		public List<uint> UInt32Slice;
		public List<long> Int64Slice;
		public List<ulong> UInt64Slice;
		public List<float> Float32Slice;
		public List<double> Float64Slice;
		public List<string> StrSlice;
		public MyEnum Enum;
		public List<MyEnum> EnumSlice;
		
		#region Serialize Code
		public void Init( )
		{   
			BoolSlice = new List<bool>();	
			Int32Slice = new List<int>();	
			UInt32Slice = new List<uint>();	
			Int64Slice = new List<long>();	
			UInt64Slice = new List<ulong>();	
			Float32Slice = new List<float>();	
			Float64Slice = new List<double>();	
			StrSlice = new List<string>();	
			EnumSlice = new List<MyEnum>();	
 			                   
		}

		public void Marshal(OutputStream stream)
		{  
			stream.WriteBool(1, Bool );  
			stream.WriteInt32(2, Int32 );  
			stream.WriteUInt32(3, UInt32 );  
			stream.WriteInt64(4, Int64 );  
			stream.WriteUInt64(5, UInt64 );  
			stream.WriteFloat(6, Float32 );  
			stream.WriteDouble(7, Float64 );  
			stream.WriteString(8, Str );  
			stream.WriteBytes(9, BytesSlice );  
			stream.WriteBool(10, BoolSlice );  
			stream.WriteInt32(11, Int32Slice );  
			stream.WriteUInt32(12, UInt32Slice );  
			stream.WriteInt64(13, Int64Slice );  
			stream.WriteUInt64(14, UInt64Slice );  
			stream.WriteFloat(15, Float32Slice );  
			stream.WriteDouble(16, Float64Slice );  
			stream.WriteString(17, StrSlice );  
			stream.WriteEnum(18, Enum );  
			stream.WriteEnum(19, EnumSlice ); 
		}

		public int GetSize()
		{
			int size = 0;  
			size += OutputStream.SizeBool(1, Bool);  
			size += OutputStream.SizeInt32(2, Int32);  
			size += OutputStream.SizeUInt32(3, UInt32);  
			size += OutputStream.SizeInt64(4, Int64);  
			size += OutputStream.SizeUInt64(5, UInt64);  
			size += OutputStream.SizeFloat(6, Float32);  
			size += OutputStream.SizeDouble(7, Float64);  
			size += OutputStream.SizeString(8, Str);  
			size += OutputStream.SizeBytes(9, BytesSlice);  
			size += OutputStream.SizeBool(10, BoolSlice);  
			size += OutputStream.SizeInt32(11, Int32Slice);  
			size += OutputStream.SizeUInt32(12, UInt32Slice);  
			size += OutputStream.SizeInt64(13, Int64Slice);  
			size += OutputStream.SizeUInt64(14, UInt64Slice);  
			size += OutputStream.SizeFloat(15, Float32Slice);  
			size += OutputStream.SizeDouble(16, Float64Slice);  
			size += OutputStream.SizeString(17, StrSlice);  
			size += OutputStream.SizeEnum(18, Enum);  
			size += OutputStream.SizeEnum(19, EnumSlice); 
			return size;
		}

 		public bool Unmarshal(InputStream stream, int fieldNumber, WireFormat.WireType wt)
		{
		 	switch (fieldNumber)
            { 
			case 1:	
				stream.ReadBool(wt, ref Bool);
                break; 
			case 2:	
				stream.ReadInt32(wt, ref Int32);
                break; 
			case 3:	
				stream.ReadUInt32(wt, ref UInt32);
                break; 
			case 4:	
				stream.ReadInt64(wt, ref Int64);
                break; 
			case 5:	
				stream.ReadUInt64(wt, ref UInt64);
                break; 
			case 6:	
				stream.ReadFloat(wt, ref Float32);
                break; 
			case 7:	
				stream.ReadDouble(wt, ref Float64);
                break; 
			case 8:	
				stream.ReadString(wt, ref Str);
                break; 
			case 9:	
				stream.ReadBytes(wt, ref BytesSlice);
                break; 
			case 10:	
				stream.ReadBool(wt, ref BoolSlice);
                break; 
			case 11:	
				stream.ReadInt32(wt, ref Int32Slice);
                break; 
			case 12:	
				stream.ReadUInt32(wt, ref UInt32Slice);
                break; 
			case 13:	
				stream.ReadInt64(wt, ref Int64Slice);
                break; 
			case 14:	
				stream.ReadUInt64(wt, ref UInt64Slice);
                break; 
			case 15:	
				stream.ReadFloat(wt, ref Float32Slice);
                break; 
			case 16:	
				stream.ReadDouble(wt, ref Float64Slice);
                break; 
			case 17:	
				stream.ReadString(wt, ref StrSlice);
                break; 
			case 18:	
				stream.ReadEnum(wt, ref Enum);
                break; 
			case 19:	
				stream.ReadEnum(wt, ref EnumSlice);
                break; 
			default:
				return true;
            }

            return false;
		}
		#endregion
	}

	
	public partial class MyType : IProtoStruct 
	{
		public bool Bool;
		public int Int32;
		public uint UInt32;
		public long Int64;
		public ulong UInt64;
		public float Float32;
		public double Float64;
		public string Str;
		public MySubType Struct;
		public byte[] BytesSlice;
		public List<bool> BoolSlice;
		public List<int> Int32Slice;
		public List<uint> UInt32Slice;
		public List<long> Int64Slice;
		public List<ulong> UInt64Slice;
		public List<float> Float32Slice;
		public List<double> Float64Slice;
		public List<string> StrSlice;
		public List<MySubType> StructSlice;
		public MyEnum Enum;
		public List<MyEnum> EnumSlice;
		
		#region Serialize Code
		public void Init( )
		{   
			BoolSlice = new List<bool>();	
			Int32Slice = new List<int>();	
			UInt32Slice = new List<uint>();	
			Int64Slice = new List<long>();	
			UInt64Slice = new List<ulong>();	
			Float32Slice = new List<float>();	
			Float64Slice = new List<double>();	
			StrSlice = new List<string>();	
			EnumSlice = new List<MyEnum>();	
 			        
			Struct = (MySubType) InputStream.CreateStruct(typeof(MySubType));              
		}

		public void Marshal(OutputStream stream)
		{  
			stream.WriteBool(1, Bool );  
			stream.WriteInt32(2, Int32 );  
			stream.WriteUInt32(3, UInt32 );  
			stream.WriteInt64(4, Int64 );  
			stream.WriteUInt64(5, UInt64 );  
			stream.WriteFloat(6, Float32 );  
			stream.WriteDouble(7, Float64 );  
			stream.WriteString(8, Str );  
			stream.WriteStruct(9, Struct );  
			stream.WriteBytes(10, BytesSlice );  
			stream.WriteBool(11, BoolSlice );  
			stream.WriteInt32(12, Int32Slice );  
			stream.WriteUInt32(13, UInt32Slice );  
			stream.WriteInt64(14, Int64Slice );  
			stream.WriteUInt64(15, UInt64Slice );  
			stream.WriteFloat(16, Float32Slice );  
			stream.WriteDouble(17, Float64Slice );  
			stream.WriteString(18, StrSlice );  
			stream.WriteStruct(19, StructSlice );  
			stream.WriteEnum(20, Enum );  
			stream.WriteEnum(21, EnumSlice ); 
		}

		public int GetSize()
		{
			int size = 0;  
			size += OutputStream.SizeBool(1, Bool);  
			size += OutputStream.SizeInt32(2, Int32);  
			size += OutputStream.SizeUInt32(3, UInt32);  
			size += OutputStream.SizeInt64(4, Int64);  
			size += OutputStream.SizeUInt64(5, UInt64);  
			size += OutputStream.SizeFloat(6, Float32);  
			size += OutputStream.SizeDouble(7, Float64);  
			size += OutputStream.SizeString(8, Str);  
			size += OutputStream.SizeStruct(9, Struct);  
			size += OutputStream.SizeBytes(10, BytesSlice);  
			size += OutputStream.SizeBool(11, BoolSlice);  
			size += OutputStream.SizeInt32(12, Int32Slice);  
			size += OutputStream.SizeUInt32(13, UInt32Slice);  
			size += OutputStream.SizeInt64(14, Int64Slice);  
			size += OutputStream.SizeUInt64(15, UInt64Slice);  
			size += OutputStream.SizeFloat(16, Float32Slice);  
			size += OutputStream.SizeDouble(17, Float64Slice);  
			size += OutputStream.SizeString(18, StrSlice);  
			size += OutputStream.SizeStruct(19, StructSlice);  
			size += OutputStream.SizeEnum(20, Enum);  
			size += OutputStream.SizeEnum(21, EnumSlice); 
			return size;
		}

 		public bool Unmarshal(InputStream stream, int fieldNumber, WireFormat.WireType wt)
		{
		 	switch (fieldNumber)
            { 
			case 1:	
				stream.ReadBool(wt, ref Bool);
                break; 
			case 2:	
				stream.ReadInt32(wt, ref Int32);
                break; 
			case 3:	
				stream.ReadUInt32(wt, ref UInt32);
                break; 
			case 4:	
				stream.ReadInt64(wt, ref Int64);
                break; 
			case 5:	
				stream.ReadUInt64(wt, ref UInt64);
                break; 
			case 6:	
				stream.ReadFloat(wt, ref Float32);
                break; 
			case 7:	
				stream.ReadDouble(wt, ref Float64);
                break; 
			case 8:	
				stream.ReadString(wt, ref Str);
                break; 
			case 9:	
				stream.ReadStruct(wt, ref Struct);
                break; 
			case 10:	
				stream.ReadBytes(wt, ref BytesSlice);
                break; 
			case 11:	
				stream.ReadBool(wt, ref BoolSlice);
                break; 
			case 12:	
				stream.ReadInt32(wt, ref Int32Slice);
                break; 
			case 13:	
				stream.ReadUInt32(wt, ref UInt32Slice);
                break; 
			case 14:	
				stream.ReadInt64(wt, ref Int64Slice);
                break; 
			case 15:	
				stream.ReadUInt64(wt, ref UInt64Slice);
                break; 
			case 16:	
				stream.ReadFloat(wt, ref Float32Slice);
                break; 
			case 17:	
				stream.ReadDouble(wt, ref Float64Slice);
                break; 
			case 18:	
				stream.ReadString(wt, ref StrSlice);
                break; 
			case 19:	
				stream.ReadStruct(wt, ref StructSlice);
                break; 
			case 20:	
				stream.ReadEnum(wt, ref Enum);
                break; 
			case 21:	
				stream.ReadEnum(wt, ref EnumSlice);
                break; 
			default:
				return true;
            }

            return false;
		}
		#endregion
	}



	public static class MessageMetaRegister
    {
		public static void RegisterGeneratedMeta(MessageMeta meta)
		{	 
            meta.RegisterMeta(new MetaInfo
            {
				Type = typeof(MySubType),	
				ID = 33606, 	
				SourcePeer = "client",
				TargetPeer = "game",
            }); 
            meta.RegisterMeta(new MetaInfo
            {
				Type = typeof(MyType),	
				ID = 9980, 	
				SourcePeer = "",
				TargetPeer = "",
            }); 
		}
    }

}