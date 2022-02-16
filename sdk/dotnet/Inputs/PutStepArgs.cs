// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Concourse.Inputs
{

    public sealed class PutStepArgs : Pulumi.ResourceArgs
    {
        [Input("get_params")]
        private InputMap<string>? _get_params;
        public InputMap<string> Get_params
        {
            get => _get_params ?? (_get_params = new InputMap<string>());
            set => _get_params = value;
        }

        [Input("params")]
        private InputMap<string>? _params;
        public InputMap<string> Params
        {
            get => _params ?? (_params = new InputMap<string>());
            set => _params = value;
        }

        [Input("put", required: true)]
        public Input<string> Put { get; set; } = null!;

        [Input("resource")]
        public Input<string>? Resource { get; set; }

        public PutStepArgs()
        {
        }
    }
}
