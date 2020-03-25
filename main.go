package main

import (
	"flag"
	"fmt"
	_ "github.com/bobwong89757/protoplus/codegen"
	"github.com/bobwong89757/protoplus/gen"
	"github.com/bobwong89757/protoplus/gen/csharp"
	"github.com/bobwong89757/protoplus/gen/gogopb"
	"github.com/bobwong89757/protoplus/gen/golang"
	"github.com/bobwong89757/protoplus/gen/json"
	_ "github.com/bobwong89757/protoplus/gen/json"
	"github.com/bobwong89757/protoplus/model"
	"github.com/bobwong89757/protoplus/util"
	"os"
)

// 显示版本号
var (
	flagVersion    = flag.Bool("version", false, "Show version")
	flagPackage    = flag.String("package", "", "package name in source files")
	flagPbOut      = flag.String("pb_out", "", "output google protobuf schema file")
	flagGoOut      = flag.String("go_out", "", "output golang source file")
	flagCSOut      = flag.String("cs_out", "", "output csharp source file")
	flagJsonOut    = flag.String("json_out", "", "output json file")
	flagJson       = flag.Bool("json", false, "output json to std out")
	flagGenReg     = flag.Bool("genreg", false, "gen message register entry")
	flagStructBase = flag.String("structbase", "IProtoStruct", "struct inherite class type name in c#")
)

const Version = "0.1.0"

func main() {

	flag.Parse()

	// 版本
	if *flagVersion {
		fmt.Println(Version)
		return
	}

	var err error
	var ctx gen.Context
	ctx.DescriptorSet = new(model.DescriptorSet)
	ctx.PackageName = *flagPackage
	ctx.StructBase = *flagStructBase
	ctx.RegEntry = *flagGenReg

	err = util.ParseFileList(ctx.DescriptorSet)

	if err != nil {
		goto OnError
	}

	if *flagGoOut != "" {
		ctx.OutputFileName = *flagGoOut

		err = golang.GenGo(&ctx)

		if err != nil {
			goto OnError
		}
	}

	if *flagCSOut != "" {
		ctx.OutputFileName = *flagCSOut

		err = csharp.GenCSharp(&ctx)

		if err != nil {
			goto OnError
		}
	}

	if *flagPbOut != "" {
		ctx.OutputFileName = *flagPbOut

		err = gogopb.GenProto(&ctx)

		if err != nil {
			goto OnError
		}
	}

	if *flagJsonOut != "" {
		ctx.OutputFileName = *flagJsonOut

		err = json.GenJson(&ctx)

		if err != nil {
			goto OnError
		}
	}

	if *flagJson {

		err = json.OutputJson(&ctx)

		if err != nil {
			goto OnError
		}
	}

	return

OnError:
	fmt.Println(err)
	os.Exit(1)
}
