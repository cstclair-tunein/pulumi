// *** WARNING: this file was generated by test. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Example.Nested.Inputs
{

    public sealed class Baz : Pulumi.InvokeArgs
    {
        [Input("hello")]
        public string? Hello { get; set; }

        [Input("world")]
        public string? World { get; set; }

        public Baz()
        {
        }
    }
}
