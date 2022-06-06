using System;
using System.Linq;
using System.Reactive.Linq;
using System.Windows.Markup;
using BookstoreManagement.Data.Model.Api;

namespace BookstoreManagement.Utils.Converters;

public class GenderEnumConverter : MarkupExtension {
    public Type EnumType { get; set; }

    public GenderEnumConverter(Type enumType) {
        if (enumType == null || !enumType.IsEnum)
            throw new Exception("EnumType must not be null and of type Enum");
        EnumType = enumType;
    }

    public override object ProvideValue(IServiceProvider serviceProvider) {
        return Enum.GetValues(EnumType)
            .Cast<object>()
            .Where(e => (Gender) e != Gender.None)
            .Select(e => new { Value = e, Display = e });
    }
}