package golang

import (
	"fmt"
	"protoplus/codegen"
	"protoplus/gen"
	_ "protoplus/msgidutil"
)

func GenGo(ctx *gen.Context) error {

	gen := codegen.NewCodeGen("go").
		RegisterTemplateFunc(codegen.UsefulFunc).
		RegisterTemplateFunc(UsefulFunc).
		ParseTemplate(TemplateText, ctx).
		FormatGoCode()

	if gen.Error() != nil {
		fmt.Println(string(gen.Code()))
		return gen.Error()
	}

	return gen.WriteOutputFile(ctx.OutputFileName).Error()
}
