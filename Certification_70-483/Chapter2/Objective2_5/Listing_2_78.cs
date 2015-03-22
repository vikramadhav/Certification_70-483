namespace Certification.Chapter2.Objective2_5
{
    using System;

    using Certification.Common;
    using System.Linq.Expressions;

    [Listing("Expression tree")]
    public class Listing_2_78 : IRunnable
    {
        public void Run()
        {
            BlockExpression blockExpr = Expression.Block(
                Expression.Call(
                    null,
                    typeof(Console).GetMethod("Write", new Type[] { typeof(String) }),
                    Expression.Constant("Hello ")
                ),
                Expression.Call(
                    null,
                    typeof(Console).GetMethod("WriteLine", new Type[] { typeof(String) }),
                    Expression.Constant("World!")
                )
            );
            Expression.Lambda<Action>(blockExpr).Compile()();
        }
    }
}
