﻿using DecoratorOk.Options;

namespace DecoratorOk.Decorators
{
    public class BOptionDecorator : OptionDecorator
    {
        public List<OptionB> BOptions { get; set; }

        public override string GetDescription()
        {
            string options = string.Join(", ", BOptions.Select(o => o.Name));
            return Car.GetDescription() + ", " + options;
        }

        public override int GetTotalPrice()
        {
            var priceAOptions = BOptions.Select(o => o.Price).Sum();
            return Car.GetTotalPrice() + priceAOptions;
        }
    }
}
