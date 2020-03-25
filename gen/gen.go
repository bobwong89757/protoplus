package gen

import (
	"protoplus/model"
)

type Context struct {
	*model.DescriptorSet
	OutputFileName string
	StructBase     string
	RegEntry       bool
}
