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

namespace Microsoft.Data.OData.Query
{
    #region Namespaces
    #endregion Namespaces

    /// <summary>
    /// Lexical token representing an order by operation.
    /// </summary>
#if INTERNAL_DROP
    internal sealed class OrderByQueryToken : QueryToken
#else
    public sealed class OrderByQueryToken : QueryToken
#endif
    {
        /// <summary>
        /// The direction of the ordering.
        /// </summary>
        private readonly OrderByDirection direction;

        /// <summary>
        /// The expression according to which to order the results.
        /// </summary>
        private readonly QueryToken expression;

        /// <summary>
        /// Create a new OrderByQueryToken given the expression and direction
        /// </summary>
        /// <param name="expression">The expression according to which to order the results.</param>
        /// <param name="direction">The direction of the ordering.</param>
        public OrderByQueryToken(QueryToken expression, OrderByDirection direction)
        {
            ExceptionUtils.CheckArgumentNotNull(expression, "expression");

            this.expression = expression;
            this.direction = direction;
        }

        /// <summary>
        /// The kind of the query token.
        /// </summary>
        public override QueryTokenKind Kind
        {
            get { return QueryTokenKind.OrderBy; }
        }

        /// <summary>
        /// The direction of the ordering.
        /// </summary>
        public OrderByDirection Direction
        {
            get { return this.direction; }
        }

        /// <summary>
        /// The expression according to which to order the results.
        /// </summary>
        public QueryToken Expression
        {
            get { return this.expression; }
        }
    }
}
