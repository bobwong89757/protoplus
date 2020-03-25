package util

import (
	"flag"
	"protoplus/model"
	"protoplus/parser"
)

func ParseFileList(dset *model.DescriptorSet) (retErr error) {

	err := parser.ParseFileList(dset, flag.Args()...)
	if err != nil {
		return err
	}

	return

}
