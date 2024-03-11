namespace Mapper;

// 1 objectni boshqa tipdagi objectga generic extension orqali map qilish

public static class GenericExtension
{
    public static TToEntity Mapto<TFromEntity, TToEntity>(this TFromEntity fromEntity)
    {
        //kiritilgan objectni tipini va propertylarini olish
        var properties = typeof(TFromEntity).GetProperties();
        
        //return qiladigan yangi tipni yaratish
        var toEntity = Activator.CreateInstance<TToEntity>();


        foreach ( var property in properties)
        {
            //propertylarni nomini olish
            var toEntityProperties = typeof(TToEntity).GetProperty(property.Name);

            if (toEntityProperties != null && toEntityProperties.CanWrite)
            {
                //kiritilgan tipdagi object propertylarni o'giradigan tip objectiga o'girish
                toEntityProperties.SetValue(toEntity, property.GetValue(fromEntity));
            }
        }

        return toEntity;
    }
}