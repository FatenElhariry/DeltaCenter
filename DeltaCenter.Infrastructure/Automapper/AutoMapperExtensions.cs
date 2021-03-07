using System.Linq;
using System.Reflection;
using AutoMapper;

namespace DeltaCenter.Infrastructure.Automapper
{
	public static class AutoMapperExtensions
	{
		public static IMappingExpression
		  IgnoreAllNonExisting(this IMappingExpression expression,TypeMap typeMap)
		{
			var flags = BindingFlags.Public | BindingFlags.Instance;
			var sourceType = typeMap.SourceType;
			var destinationProperties = typeMap.DestinationType.GetProperties(flags);

			foreach (var property in destinationProperties)
			{
				if (sourceType.GetProperties(flags).All(t => t.Name.ToLowerInvariant() != property.Name.ToLowerInvariant()))
				{
					expression.ForMember(property.Name, opt => opt.Ignore());
				}
			}
			return expression;
		}

		public static IMappingExpression<TSource, TDestination>
		  IgnoreAllNonExisting<TSource, TDestination>(this IMappingExpression<TSource, TDestination> expression)
		{
			var flags = BindingFlags.Public | BindingFlags.Instance;
			var sourceType = typeof(TSource);
			var destinationProperties = typeof(TDestination).GetProperties(flags);

			foreach (var property in destinationProperties)
			{
				if (sourceType.GetProperties(flags).All(t => t.Name.ToLowerInvariant() != property.Name.ToLowerInvariant()))
				{
					expression.ForMember(property.Name, opt => opt.Ignore());
				}
			}
			return expression;
		}
	}
}
