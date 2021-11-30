// *** WARNING: this file was generated by test. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi.Utilities;

namespace Pulumi.Mypkg
{
    public static class FuncWithListParam
    {
        /// <summary>
        /// Check codegen of functions with a List parameter.
        /// </summary>
        public static Task<FuncWithListParamResult> InvokeAsync(FuncWithListParamArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<FuncWithListParamResult>("mypkg::funcWithListParam", args ?? new FuncWithListParamArgs(), options.WithVersion());

        /// <summary>
        /// Check codegen of functions with a List parameter.
        /// </summary>
        public static Output<FuncWithListParamResult> Invoke(FuncWithListParamInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<FuncWithListParamResult>("mypkg::funcWithListParam", args ?? new FuncWithListParamInvokeArgs(), options.WithVersion());
    }


    public sealed class FuncWithListParamArgs : Pulumi.InvokeArgs
    {
        [Input("a")]
        private List<string>? _a;
        public List<string> A
        {
            get => _a ?? (_a = new List<string>());
            set => _a = value;
        }

        [Input("b")]
        public string? B { get; set; }

        public FuncWithListParamArgs()
        {
        }
    }

    public sealed class FuncWithListParamInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("a")]
        private InputList<string>? _a;
        public InputList<string> A
        {
            get => _a ?? (_a = new InputList<string>());
            set => _a = value;
        }

        [Input("b")]
        public Input<string>? B { get; set; }

        public FuncWithListParamInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class FuncWithListParamResult
    {
        public readonly string R;

        [OutputConstructor]
        private FuncWithListParamResult(string r)
        {
            R = r;
        }
    }
}
