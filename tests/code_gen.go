// Generated by github.com/davyxu/protoplus
// DO NOT EDIT!
package tests

import (
	"github.com/davyxu/protoplus/proto"
	"fmt"
)

var (
	_ *proto.Buffer
	_ fmt.Stringer
)

type MyTypeMini struct {
	Bool bool
}

func (self *MyTypeMini) String() string { return fmt.Sprintf("%+v", *self) }

func (self *MyTypeMini) Size() (ret int) {

	ret += proto.SizeBool(0, self.Bool)

	return
}

func (self *MyTypeMini) Marshal(buffer *proto.Buffer) error {

	if err := proto.MarshalBool(buffer, 0, self.Bool); err != nil {
		return err
	}

	return nil
}

func (self *MyTypeMini) Unmarshal(buffer *proto.Buffer, fieldIndex uint64, wt proto.WireType) error {
	switch fieldIndex {
	case 0:
		return proto.UnmarshalBool(buffer, wt, &self.Bool)

	}

	return proto.ErrUnknownField
}

type MyType struct {
	Bool      bool
	Int32     int32
	UInt32    uint32
	Int64     int64
	UInt64    uint64
	Float32   float32
	Float64   float64
	Str       string
	Struct    *MyType
	BoolSlice []bool
}

func (self *MyType) String() string { return fmt.Sprintf("%+v", *self) }

func (self *MyType) Size() (ret int) {

	ret += proto.SizeBool(0, self.Bool)

	ret += proto.SizeInt32(1, self.Int32)

	ret += proto.SizeUInt32(2, self.UInt32)

	ret += proto.SizeInt64(3, self.Int64)

	ret += proto.SizeUInt64(4, self.UInt64)

	ret += proto.SizeFloat32(5, self.Float32)

	ret += proto.SizeFloat64(6, self.Float64)

	ret += proto.SizeString(7, self.Str)

	ret += proto.SizeStruct(8, self.Struct)

	ret += proto.SizeBoolSlice(9, self.BoolSlice)

	return
}

func (self *MyType) Marshal(buffer *proto.Buffer) error {

	if err := proto.MarshalBool(buffer, 0, self.Bool); err != nil {
		return err
	}

	if err := proto.MarshalInt32(buffer, 1, self.Int32); err != nil {
		return err
	}

	if err := proto.MarshalUInt32(buffer, 2, self.UInt32); err != nil {
		return err
	}

	if err := proto.MarshalInt64(buffer, 3, self.Int64); err != nil {
		return err
	}

	if err := proto.MarshalUInt64(buffer, 4, self.UInt64); err != nil {
		return err
	}

	if err := proto.MarshalFloat32(buffer, 5, self.Float32); err != nil {
		return err
	}

	if err := proto.MarshalFloat64(buffer, 6, self.Float64); err != nil {
		return err
	}

	if err := proto.MarshalString(buffer, 7, self.Str); err != nil {
		return err
	}

	if err := proto.MarshalStruct(buffer, 8, self.Struct); err != nil {
		return err
	}

	if err := proto.MarshalBoolSlice(buffer, 9, self.BoolSlice); err != nil {
		return err
	}

	return nil
}

func (self *MyType) Unmarshal(buffer *proto.Buffer, fieldIndex uint64, wt proto.WireType) error {
	switch fieldIndex {
	case 0:
		return proto.UnmarshalBool(buffer, wt, &self.Bool)
	case 1:
		return proto.UnmarshalInt32(buffer, wt, &self.Int32)
	case 2:
		return proto.UnmarshalUInt32(buffer, wt, &self.UInt32)
	case 3:
		return proto.UnmarshalInt64(buffer, wt, &self.Int64)
	case 4:
		return proto.UnmarshalUInt64(buffer, wt, &self.UInt64)
	case 5:
		return proto.UnmarshalFloat32(buffer, wt, &self.Float32)
	case 6:
		return proto.UnmarshalFloat64(buffer, wt, &self.Float64)
	case 7:
		return proto.UnmarshalString(buffer, wt, &self.Str)
	case 8:
		return proto.UnmarshalStruct(buffer, wt, &self.Struct)
	case 9:
		return proto.UnmarshalBoolSlice(buffer, wt, &self.BoolSlice)

	}

	return proto.ErrUnknownField
}