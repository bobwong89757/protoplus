package csharp

import (
	"fmt"
	"protoplus/codegen"
	"protoplus/gen"
	_ "protoplus/msgidutil"
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
