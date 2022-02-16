// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Concourse.Inputs
{

    public sealed class InParallelConfigArgs : Pulumi.ResourceArgs
    {
        [Input("fail_fast")]
        public Input<bool>? Fail_fast { get; set; }

        [Input("limit")]
        public Input<double>? Limit { get; set; }

        [Input("steps", required: true)]
        private InputList<object>? _steps;
        public InputList<object> Steps
        {
            get => _steps ?? (_steps = new InputList<object>());
            set => _steps = value;
        }

        public InParallelConfigArgs()
        {
        }
    }
}
