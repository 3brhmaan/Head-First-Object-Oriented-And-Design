using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstObjectOrientedAndDesign.CH1
{
	public class GuitarSpec
	{
		Builder builder { get; set; }
		string model { get; set; }
		Type type { get; set; }
		Wood backWood { get; set; }
		Wood topWood { get; set; }

        public GuitarSpec(Builder builder , string model , Type type ,
			Wood backWood , Wood topWood)
        {
            this.builder = builder;
			this.model = model;
			this.type = type;
			this.backWood = backWood;
			this.topWood = topWood;
        }
        public Builder getBuilder() =>
			builder;
		public String getModel() =>
			model;
		public Type getType() =>
			type;
		public Wood getBackWood() =>
			backWood;
		public Wood getTopWood() =>
			topWood;

		public override bool Equals(object? obj)
		{
			if(obj is null)
				return false;
			if(obj is not GuitarSpec)
				return false;
			//if(ReferenceEquals(this, obj)) 
			//	return true;

			GuitarSpec spec = obj as GuitarSpec;

			return type.Equals(spec.type) &&
				   backWood.Equals(spec.backWood) &&
				   topWood.Equals(spec.topWood) &&
				   builder.Equals(spec.builder) &&
				   model.Equals(spec.model);
		}

	}
}
