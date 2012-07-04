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

using System;
using System.Collections.Generic;
using Microsoft.Data.Edm.Validation;

namespace Microsoft.Data.Edm.Library.Internal
{
    /// <summary>
    /// Represents a semantically invalid EDM entity reference type.
    /// </summary>
    internal class BadEntityReferenceType : BadType, IEdmEntityReferenceType
    {
        private readonly IEdmEntityType entityType;

        public BadEntityReferenceType(IEnumerable<EdmError> errors)
            : base(errors)
        {
            this.entityType = new BadEntityType(String.Empty, this.Errors);
        }

        public override EdmTypeKind TypeKind
        {
            get { return EdmTypeKind.EntityReference; }
        }

        public IEdmEntityType EntityType
        {
            get { return this.entityType; }
        }
    }
}
