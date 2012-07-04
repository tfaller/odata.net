//   Copyright 2011 Microsoft Corporation
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.

namespace Microsoft.Data.Edm.Csdl.Internal.Parsing.Ast
{
    /// <summary>
    /// Represents a CSDL function parameter.
    /// </summary>
    internal class CsdlFunctionParameter : CsdlNamedElement
    {
        private readonly CsdlTypeReference type;
        private readonly EdmFunctionParameterMode mode;

        public CsdlFunctionParameter(string name, CsdlTypeReference type, EdmFunctionParameterMode mode, CsdlDocumentation documentation, CsdlLocation location)
            : base(name, documentation, location)
        {
            this.type = type;
            this.mode = mode;
        }

        public CsdlTypeReference Type
        {
            get { return this.type; }
        }

        public EdmFunctionParameterMode Mode
        {
            get { return this.mode; }
        }
    }
}
