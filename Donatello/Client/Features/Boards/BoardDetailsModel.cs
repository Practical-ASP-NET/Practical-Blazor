using System.Collections.Generic;

namespace Donatello.Client.Features.Boards;
public class BoardDetailsModel
{
    public List<Column> Columns { get; set; } = new List<Column>();

    public class Column
    {
        public string Title { get; set; }
    }
}