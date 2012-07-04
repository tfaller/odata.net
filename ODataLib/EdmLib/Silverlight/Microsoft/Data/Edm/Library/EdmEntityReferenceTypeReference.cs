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

namespace Microsoft.Data.Edm.Library
{
    /// <summary>
    /// Represents a reference to an EDM entity reference type.
    /// </summary>
    public class EdmEntityReferenceTypeReference : EdmTypeReference, IEdmEntityReferenceTypeReference
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdmEntityReferenceTypeReference"/> class.
        /// </summary>
        /// <param name="entityReferenceType">The definition referred to by this reference.</param>
        /// <param name="isNullable">Denotes whether the type can be nullable.</param>
        public EdmEntityReferenceTypeReference(IEdmEntityReferenceType entityReferenceType, bool isNullable)
            : base(entityReferenceType, isNullable)
        {
        }

        /// <summary>
        /// Gets the entity reference definition to which this type refers.
        /// </summary>
        public IEdmEntityReferenceType EntityReferenceDefinition
        {
            get { return (IEdmEntityReferenceType)Definition; }
        }
    }
}
