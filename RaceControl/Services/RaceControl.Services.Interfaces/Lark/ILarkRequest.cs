﻿namespace RaceControl.Services.Interfaces.Lark
{
    public interface ILarkRequest
    {
        ILarkRequest WithField(string field, bool expand = false);

        ILarkRequest WithSubField(string field, string subField);

        ILarkRequest WithFilter(string field, LarkFilterType filterType, string filterValue);

        ILarkRequest OrderBy(string field, LarkSortDirection direction);

        string GetURL();
    }
}