using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeltaCenter.Infrastructure.Automapper
{
	public static class AutoMapperConfig
	{
		private static readonly object SyncRoot = new object();
		private static volatile bool _initialized;

		public static IMapper Configure()
		{
			// in normal wokflow it's simple to esnure that Initialize is run only once
			// but during tests run, every ficture can try to run this method. it creates issues since Mapper.Initialize should be run only once.
			// to work this out and to make sure that this run once we use the following construct
			lock (SyncRoot)
			{
				if (!_initialized)
				{

					var config = new MapperConfiguration(cfg =>
					{
						cfg.AddProfile<MappingProfile>();
					});
					//Mapper.Initialize(cfg =>
					//{
					//	cfg.AddProfile<MappingProfile>();
					//	cfg.ForAllMaps((map, exp) => {
					//		//exp.IgnoreAllNonExisting(map);
					//	});
					//});


#if DEBUG
					config.AssertConfigurationIsValid();
#endif

					_initialized = true;
					return config.CreateMapper();
				}

			}
			return null;
		}


		}

	}
