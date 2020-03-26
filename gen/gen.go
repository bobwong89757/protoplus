package gen

import (
	"github.com/bobwong89757/protoplus/model"
)

type Context struct {
	*model.DescriptorSet
	OutputFileName string
	StructBase     string
	RegEntry       bool
}
