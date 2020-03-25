package csharp

import (
	"fmt"
	"github.com/bobwong89757/protoplus/codegen"
	"github.com/bobwong89757/protoplus/gen"
	_ "github.com/bobwong89757/protoplus/msgidutil"
)

func GenCSharp(ctx *gen.Context) error {

	gen := codegen.NewCodeGen("cs").
		RegisterTemplateFunc(codegen.UsefulFunc).
		RegisterTemplateFunc(UsefulFunc).
		ParseTemplate(TemplateText, ctx)

	if gen.Error() != nil {
		fmt.Println(string(gen.Code()))
		return gen.Error()
	}

	return gen.WriteOutputFile(ctx.OutputFileName).Error()
}
