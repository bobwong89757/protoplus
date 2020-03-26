package util

import (
	"flag"
	"github.com/bobwong89757/protoplus/model"
	"github.com/bobwong89757/protoplus/parser"
)

func ParseFileList(dset *model.DescriptorSet) (retErr error) {

	err := parser.ParseFileList(dset, flag.Args()...)
	if err != nil {
		return err
	}

	return

}
