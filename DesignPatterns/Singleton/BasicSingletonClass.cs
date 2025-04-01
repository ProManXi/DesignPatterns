using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
   public class BasicSingletonClass
	{
		private static BasicSingletonClass cacheObj;

		private BasicSingletonClass()
		{

		}

		public static BasicSingletonClass GetInstance()
		{
			if (cacheObj == null)
			{
				cacheObj = new BasicSingletonClass();
			}
			return cacheObj;

		}
	}
}