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

namespace Microsoft.Data.OData {
    using System;
    using System.Reflection;
    using System.Globalization;
    using System.Resources;
    using System.Text;
    using System.Threading;
    using System.Security.Permissions;

    
    using System.ComponentModel;

    [AttributeUsage(AttributeTargets.All)]
    internal sealed class TextResDescriptionAttribute : DescriptionAttribute {

        private bool replaced = false;

        /// <summary>
        ///     Constructs a new sys description.
        /// </summary>
        /// <param name='description'>
        ///     description text.
        /// </param>
        public TextResDescriptionAttribute(string description) : base(description) {
        }

        /// <summary>
        ///     Retrieves the description text.
        /// </summary>
        /// <returns>
        ///     description
        /// </returns>
        public override string Description {
            get {
                if (!replaced) {
                    replaced = true;
                    DescriptionValue = TextRes.GetString(base.Description);
                }
                return base.Description;
            }
        }
    }

    [AttributeUsage(AttributeTargets.All)]
    internal sealed class TextResCategoryAttribute : CategoryAttribute {

        public TextResCategoryAttribute(string category) : base(category) {
        }

        protected override string GetLocalizedString(string value) {
            return TextRes.GetString(value);
        }
    }


    /// <summary>
    ///    AutoGenerated resource class. Usage:
    ///
    ///        string s = TextRes.GetString(TextRes.MyIdenfitier);
    /// </summary>
    
    internal sealed class TextRes {
        internal const string ODataQueryUtils_DidNotFindServiceOperation = "ODataQueryUtils_DidNotFindServiceOperation";
        internal const string ODataQueryUtils_FoundMultipleServiceOperations = "ODataQueryUtils_FoundMultipleServiceOperations";
        internal const string ODataQueryUtils_CannotSetMetadataAnnotationOnPrimitiveType = "ODataQueryUtils_CannotSetMetadataAnnotationOnPrimitiveType";
        internal const string ODataQueryUtils_DidNotFindEntitySet = "ODataQueryUtils_DidNotFindEntitySet";
        internal const string BinaryOperatorQueryNode_InvalidOperandType = "BinaryOperatorQueryNode_InvalidOperandType";
        internal const string BinaryOperatorQueryNode_OperandsMustHaveSameTypes = "BinaryOperatorQueryNode_OperandsMustHaveSameTypes";
        internal const string QueryExpressionTranslator_UnsupportedQueryNodeKind = "QueryExpressionTranslator_UnsupportedQueryNodeKind";
        internal const string QueryExpressionTranslator_UnsupportedExtensionNode = "QueryExpressionTranslator_UnsupportedExtensionNode";
        internal const string QueryExpressionTranslator_NodeTranslatedToNull = "QueryExpressionTranslator_NodeTranslatedToNull";
        internal const string QueryExpressionTranslator_NodeTranslatedToWrongType = "QueryExpressionTranslator_NodeTranslatedToWrongType";
        internal const string QueryExpressionTranslator_CollectionQueryNodeWithoutItemType = "QueryExpressionTranslator_CollectionQueryNodeWithoutItemType";
        internal const string QueryExpressionTranslator_SingleValueQueryNodeWithoutTypeReference = "QueryExpressionTranslator_SingleValueQueryNodeWithoutTypeReference";
        internal const string QueryExpressionTranslator_ConstantNonPrimitive = "QueryExpressionTranslator_ConstantNonPrimitive";
        internal const string QueryExpressionTranslator_KeyLookupOnlyOnEntities = "QueryExpressionTranslator_KeyLookupOnlyOnEntities";
        internal const string QueryExpressionTranslator_KeyLookupOnlyOnQueryable = "QueryExpressionTranslator_KeyLookupOnlyOnQueryable";
        internal const string QueryExpressionTranslator_KeyLookupWithoutKeyProperty = "QueryExpressionTranslator_KeyLookupWithoutKeyProperty";
        internal const string QueryExpressionTranslator_KeyLookupWithNoKeyValues = "QueryExpressionTranslator_KeyLookupWithNoKeyValues";
        internal const string QueryExpressionTranslator_KeyPropertyValueWithoutProperty = "QueryExpressionTranslator_KeyPropertyValueWithoutProperty";
        internal const string QueryExpressionTranslator_KeyPropertyValueWithWrongValue = "QueryExpressionTranslator_KeyPropertyValueWithWrongValue";
        internal const string QueryExpressionTranslator_FilterCollectionOfWrongType = "QueryExpressionTranslator_FilterCollectionOfWrongType";
        internal const string QueryExpressionTranslator_FilterExpressionOfWrongType = "QueryExpressionTranslator_FilterExpressionOfWrongType";
        internal const string QueryExpressionTranslator_UnaryNotOperandNotBoolean = "QueryExpressionTranslator_UnaryNotOperandNotBoolean";
        internal const string QueryExpressionTranslator_PropertyAccessSourceWrongType = "QueryExpressionTranslator_PropertyAccessSourceWrongType";
        internal const string QueryExpressionTranslator_PropertyAccessSourceNotStructured = "QueryExpressionTranslator_PropertyAccessSourceNotStructured";
        internal const string QueryExpressionTranslator_ParameterNotDefinedInScope = "QueryExpressionTranslator_ParameterNotDefinedInScope";
        internal const string QueryExpressionTranslator_OrderByCollectionOfWrongType = "QueryExpressionTranslator_OrderByCollectionOfWrongType";
        internal const string QueryExpressionTranslator_UnknownFunction = "QueryExpressionTranslator_UnknownFunction";
        internal const string QueryExpressionTranslator_FunctionArgumentNotSingleValue = "QueryExpressionTranslator_FunctionArgumentNotSingleValue";
        internal const string QueryExpressionTranslator_NoApplicableFunctionFound = "QueryExpressionTranslator_NoApplicableFunctionFound";
        internal const string QueryDescriptorQueryToken_UriMustBeAbsolute = "QueryDescriptorQueryToken_UriMustBeAbsolute";
        internal const string QueryDescriptorQueryToken_MaxDepthInvalid = "QueryDescriptorQueryToken_MaxDepthInvalid";
        internal const string QueryDescriptorQueryToken_InvalidSkipQueryOptionValue = "QueryDescriptorQueryToken_InvalidSkipQueryOptionValue";
        internal const string QueryDescriptorQueryToken_InvalidTopQueryOptionValue = "QueryDescriptorQueryToken_InvalidTopQueryOptionValue";
        internal const string QueryDescriptorQueryToken_InvalidInlineCountQueryOptionValue = "QueryDescriptorQueryToken_InvalidInlineCountQueryOptionValue";
        internal const string QueryOptionUtils_QueryParameterMustBeSpecifiedOnce = "QueryOptionUtils_QueryParameterMustBeSpecifiedOnce";
        internal const string UriBuilder_NotSupportedClrLiteral = "UriBuilder_NotSupportedClrLiteral";
        internal const string UriBuilder_NotSupportedQueryToken = "UriBuilder_NotSupportedQueryToken";
        internal const string UriQueryExpressionParser_TooDeep = "UriQueryExpressionParser_TooDeep";
        internal const string UriQueryExpressionParser_ExpressionExpected = "UriQueryExpressionParser_ExpressionExpected";
        internal const string UriQueryExpressionParser_OpenParenExpected = "UriQueryExpressionParser_OpenParenExpected";
        internal const string UriQueryExpressionParser_CloseParenOrCommaExpected = "UriQueryExpressionParser_CloseParenOrCommaExpected";
        internal const string UriQueryExpressionParser_CloseParenOrOperatorExpected = "UriQueryExpressionParser_CloseParenOrOperatorExpected";
        internal const string UriQueryPathParser_RequestUriDoesNotHaveTheCorrectBaseUri = "UriQueryPathParser_RequestUriDoesNotHaveTheCorrectBaseUri";
        internal const string UriQueryPathParser_SyntaxError = "UriQueryPathParser_SyntaxError";
        internal const string UriQueryPathParser_TooManySegments = "UriQueryPathParser_TooManySegments";
        internal const string UriQueryPathParser_InvalidKeyValueLiteral = "UriQueryPathParser_InvalidKeyValueLiteral";
        internal const string PropertyInfoTypeAnnotation_CannotFindProperty = "PropertyInfoTypeAnnotation_CannotFindProperty";
        internal const string MetadataBinder_UnsupportedQueryTokenKind = "MetadataBinder_UnsupportedQueryTokenKind";
        internal const string MetadataBinder_UnsupportedExtensionToken = "MetadataBinder_UnsupportedExtensionToken";
        internal const string MetadataBinder_RootSegmentResourceNotFound = "MetadataBinder_RootSegmentResourceNotFound";
        internal const string MetadataBinder_KeyValueApplicableOnlyToEntityType = "MetadataBinder_KeyValueApplicableOnlyToEntityType";
        internal const string MetadataBinder_PropertyNotDeclared = "MetadataBinder_PropertyNotDeclared";
        internal const string MetadataBinder_PropertyNotDeclaredOrNotKeyInKeyValue = "MetadataBinder_PropertyNotDeclaredOrNotKeyInKeyValue";
        internal const string MetadataBinder_UnnamedKeyValueOnTypeWithMultipleKeyProperties = "MetadataBinder_UnnamedKeyValueOnTypeWithMultipleKeyProperties";
        internal const string MetadataBinder_DuplicitKeyPropertyInKeyValues = "MetadataBinder_DuplicitKeyPropertyInKeyValues";
        internal const string MetadataBinder_NotAllKeyPropertiesSpecifiedInKeyValues = "MetadataBinder_NotAllKeyPropertiesSpecifiedInKeyValues";
        internal const string MetadataBinder_CannotConvertToType = "MetadataBinder_CannotConvertToType";
        internal const string MetadataBinder_NonQueryableServiceOperationWithKeyLookup = "MetadataBinder_NonQueryableServiceOperationWithKeyLookup";
        internal const string MetadataBinder_QueryServiceOperationOfNonEntityType = "MetadataBinder_QueryServiceOperationOfNonEntityType";
        internal const string MetadataBinder_ServiceOperationParameterMissing = "MetadataBinder_ServiceOperationParameterMissing";
        internal const string MetadataBinder_ServiceOperationParameterInvalidType = "MetadataBinder_ServiceOperationParameterInvalidType";
        internal const string MetadataBinder_FilterNotApplicable = "MetadataBinder_FilterNotApplicable";
        internal const string MetadataBinder_FilterExpressionNotSingleValue = "MetadataBinder_FilterExpressionNotSingleValue";
        internal const string MetadataBinder_OrderByNotApplicable = "MetadataBinder_OrderByNotApplicable";
        internal const string MetadataBinder_OrderByExpressionNotSingleValue = "MetadataBinder_OrderByExpressionNotSingleValue";
        internal const string MetadataBinder_SkipNotApplicable = "MetadataBinder_SkipNotApplicable";
        internal const string MetadataBinder_TopNotApplicable = "MetadataBinder_TopNotApplicable";
        internal const string MetadataBinder_PropertyAccessWithoutParentParameter = "MetadataBinder_PropertyAccessWithoutParentParameter";
        internal const string MetadataBinder_MultiValuePropertyNotSupportedInExpression = "MetadataBinder_MultiValuePropertyNotSupportedInExpression";
        internal const string MetadataBinder_BinaryOperatorOperandNotSingleValue = "MetadataBinder_BinaryOperatorOperandNotSingleValue";
        internal const string MetadataBinder_UnaryOperatorOperandNotSingleValue = "MetadataBinder_UnaryOperatorOperandNotSingleValue";
        internal const string MetadataBinder_PropertyAccessSourceNotSingleValue = "MetadataBinder_PropertyAccessSourceNotSingleValue";
        internal const string MetadataBinder_IncompatibleOperandsError = "MetadataBinder_IncompatibleOperandsError";
        internal const string MetadataBinder_IncompatibleOperandError = "MetadataBinder_IncompatibleOperandError";
        internal const string MetadataBinder_UnknownFunction = "MetadataBinder_UnknownFunction";
        internal const string MetadataBinder_FunctionArgumentNotSingleValue = "MetadataBinder_FunctionArgumentNotSingleValue";
        internal const string MetadataBinder_NoApplicableFunctionFound = "MetadataBinder_NoApplicableFunctionFound";
        internal const string MetadataBinder_UnsupportedSystemQueryOption = "MetadataBinder_UnsupportedSystemQueryOption";
        internal const string MetadataBinder_BoundNodeCannotBeNull = "MetadataBinder_BoundNodeCannotBeNull";
        internal const string MetadataBinder_TopRequiresNonNegativeInteger = "MetadataBinder_TopRequiresNonNegativeInteger";
        internal const string MetadataBinder_SkipRequiresNonNegativeInteger = "MetadataBinder_SkipRequiresNonNegativeInteger";
        internal const string MetadataBinder_ServiceOperationWithoutResultKind = "MetadataBinder_ServiceOperationWithoutResultKind";
        internal const string General_InternalError = "General_InternalError";
        internal const string ExceptionUtils_CheckIntegerNotNegative = "ExceptionUtils_CheckIntegerNotNegative";
        internal const string ExceptionUtils_CheckIntegerPositive = "ExceptionUtils_CheckIntegerPositive";
        internal const string ExceptionUtils_CheckLongPositive = "ExceptionUtils_CheckLongPositive";
        internal const string ExceptionUtils_ArgumentStringNullOrEmpty = "ExceptionUtils_ArgumentStringNullOrEmpty";
        internal const string ExpressionToken_IdentifierExpected = "ExpressionToken_IdentifierExpected";
        internal const string ExpressionLexer_UnterminatedStringLiteral = "ExpressionLexer_UnterminatedStringLiteral";
        internal const string ExpressionLexer_InvalidCharacter = "ExpressionLexer_InvalidCharacter";
        internal const string ExpressionLexer_SyntaxError = "ExpressionLexer_SyntaxError";
        internal const string ExpressionLexer_UnterminatedLiteral = "ExpressionLexer_UnterminatedLiteral";
        internal const string ExpressionLexer_DigitExpected = "ExpressionLexer_DigitExpected";
        internal const string UriQueryExpressionParser_UnrecognizedLiteral = "UriQueryExpressionParser_UnrecognizedLiteral";

        static TextRes loader = null;
        ResourceManager resources;

        internal TextRes() {
            resources = new System.Resources.ResourceManager("Microsoft.Data.OData", this.GetType().Assembly);
        }
        
        private static TextRes GetLoader() {
            if (loader == null) {
                TextRes sr = new TextRes();
                Interlocked.CompareExchange(ref loader, sr, null);
            }
            return loader;
        }

        private static CultureInfo Culture {
            get { return null/*use ResourceManager default, CultureInfo.CurrentUICulture*/; }
        }
        
        public static ResourceManager Resources {
            get {
                return GetLoader().resources;
            }
        }
        
        public static string GetString(string name, params object[] args) {
            TextRes sys = GetLoader();
            if (sys == null)
                return null;
            string res = sys.resources.GetString(name, TextRes.Culture);

            if (args != null && args.Length > 0) {
                for (int i = 0; i < args.Length; i ++) {
                    String value = args[i] as String;
                    if (value != null && value.Length > 1024) {
                        args[i] = value.Substring(0, 1024 - 3) + "...";
                    }
                }
                return String.Format(CultureInfo.CurrentCulture, res, args);
            }
            else {
                return res;
            }
        }

        public static string GetString(string name) {
            TextRes sys = GetLoader();
            if (sys == null)
                return null;
            return sys.resources.GetString(name, TextRes.Culture);
        }
        
        public static string GetString(string name, out bool usedFallback) {
            // always false for this version of gensr
            usedFallback = false;
            return GetString(name);
        }

        public static object GetObject(string name) {
            TextRes sys = GetLoader();
            if (sys == null)
                return null;
            return sys.resources.GetObject(name, TextRes.Culture);
        }
    }
}
