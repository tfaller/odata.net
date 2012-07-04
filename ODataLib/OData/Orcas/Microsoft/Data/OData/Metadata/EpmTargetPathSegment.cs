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

namespace Microsoft.Data.OData.Metadata
{
    #region Namespaces
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    #endregion Namespaces

    /// <summary>
    /// Representation of each node in the EpmTargetTree.
    /// </summary>
    [DebuggerDisplay("EpmTargetPathSegment {SegmentName} HasContent={HasContent}")]
    internal sealed class EpmTargetPathSegment
    {
        #region Private fields
        /// <summary>
        /// Name of the xml element/attribute.
        /// </summary>
        /// <remarks>This field is used to differentiate between special nodes as well.
        /// - null - this is the root of the target tree.
        /// - anything else (doesn't start with @) - this node represents an element with the specified name.
        /// - anything else (starts with @) - this node represents an attribute with the specified name.</remarks>
        private readonly string segmentName;

        /// <summary>
        /// Cached attribute name if the segment represents an attribute.
        /// </summary>
        private readonly string segmentAttributeName;

        /// <summary>
        /// URI of the namespace to which the <see cref="segmentName"/> belongs.
        /// </summary>
        private readonly string segmentNamespaceUri;

        /// <summary>
        /// Prefix to be used in xml document for <see cref="segmentNamespaceUri"/>.
        /// </summary>
        private readonly string segmentNamespacePrefix;

        /// <summary>
        /// If this is a non-leaf element, the child elements/attributes collection.
        /// </summary>
        private readonly List<EpmTargetPathSegment> subSegments;

        /// <summary>
        /// Parent element of this element/attribute.
        /// </summary>
        private readonly EpmTargetPathSegment parentSegment;

        /// <summary>
        /// The EPM info object for this target segment, if there's any.
        /// </summary>
        private EntityPropertyMappingInfo epmInfo;
        #endregion Private fields

        /// <summary>
        /// Constructor initializes the list of sub-nodes to be empty, used for creating root nodes
        /// in the EpmTargetTree.
        /// </summary>
        internal EpmTargetPathSegment()
        {
            DebugUtils.CheckNoExternalCallers();
            this.subSegments = new List<EpmTargetPathSegment>();
        }

        /// <summary>
        /// Used for creating non-root nodes in the syndication/custom trees.
        /// </summary>
        /// <param name="segmentName">Name of xml element/attribute</param>
        /// <param name="segmentNamespaceUri">URI of the namespace for <paramref name="segmentName"/></param>
        /// <param name="segmentNamespacePrefix">Namespace prefix to be used for <paramref name="segmentNamespaceUri"/></param>
        /// <param name="parentSegment">Reference to the parent node if this is a sub-node, useful for traversals in visitors</param>
        internal EpmTargetPathSegment(string segmentName, string segmentNamespaceUri, string segmentNamespacePrefix, EpmTargetPathSegment parentSegment)
            : this()
        {
            DebugUtils.CheckNoExternalCallers();
            Debug.Assert(segmentName == null || segmentName.Length > 0, "Empty segment name is not allowed.");

            this.segmentName = segmentName;
            this.segmentNamespaceUri = segmentNamespaceUri;
            this.segmentNamespacePrefix = segmentNamespacePrefix;
            this.parentSegment = parentSegment;

            if (!string.IsNullOrEmpty(segmentName) && segmentName[0] == '@')
            {
                this.segmentAttributeName = segmentName.Substring(1);
            }
        }

        /// <summary>
        /// Name of the xml element/attribute.
        /// </summary>
        /// <remarks>This property is used to differentiate between special nodes as well.
        /// - null - this is the root of the target tree.
        /// - anything else (doesn't start with @) - this node represents an element with the specified name.
        /// - anything else (starts with @) - this node represents an attribute with the specified name.
        /// The value of the property should not be compared directly to differentiate between these cases, instead
        /// properties IsAttribute and IsElementContentSegment should be used. The root node should not be accessed directly
        /// from anywhere so far.</remarks>
        internal string SegmentName
        {
            get
            {
                DebugUtils.CheckNoExternalCallers();
                return this.segmentName;
            }
        }

        /// <summary>
        /// Retruns name of the attribute the property is mapped to. Must not be called if a property is mapped to an element.
        /// </summary>
        internal string AttributeName
        {
            get
            {
                DebugUtils.CheckNoExternalCallers();
                Debug.Assert(this.IsAttribute, "This property should be called only for attributes");
                return this.segmentAttributeName;
            }
        }

        /// <summary>
        /// URI of the namespace to which the <see cref="segmentName"/> belongs.
        /// </summary>
        internal string SegmentNamespaceUri
        {
            get
            {
                DebugUtils.CheckNoExternalCallers();
                return this.segmentNamespaceUri;
            }
        }

        /// <summary>
        /// Prefix to be used in xml document for <see cref="segmentNamespaceUri"/>.
        /// </summary>
        internal String SegmentNamespacePrefix
        {
            get
            {
                DebugUtils.CheckNoExternalCallers();
                return this.segmentNamespacePrefix;
            }
        }

        /// <summary>
        /// EntityPropertyMappingInfo corresponding to current segement.
        /// </summary>
        internal EntityPropertyMappingInfo EpmInfo
        {
            get
            {
                DebugUtils.CheckNoExternalCallers();
                return this.epmInfo;
            }

            set
            {
                DebugUtils.CheckNoExternalCallers();
                this.epmInfo = value;
            }
        }

        /// <summary>
        /// Whether this node corresponds to ResourceType or ClientType property values.
        /// </summary>
        internal bool HasContent
        {
            get
            {
                DebugUtils.CheckNoExternalCallers();
                return this.EpmInfo != null;
            }
        }

        /// <summary>
        /// Does this node correspond to xml attribute.
        /// </summary>
        internal bool IsAttribute
        {
            get
            {
                DebugUtils.CheckNoExternalCallers();
                return this.segmentAttributeName != null;
            }
        }

        /// <summary>
        /// Parent node in the tree (always an element if present).
        /// </summary>
        internal EpmTargetPathSegment ParentSegment
        {
            get
            {
                DebugUtils.CheckNoExternalCallers();
                return this.parentSegment;
            }
        }

        /// <summary>
        /// Sub-nodes of this node. Only exist if current node is an element node.
        /// </summary>
        internal List<EpmTargetPathSegment> SubSegments
        {
            get
            {
                DebugUtils.CheckNoExternalCallers();
                return this.subSegments;
            }
        }
    }
}
