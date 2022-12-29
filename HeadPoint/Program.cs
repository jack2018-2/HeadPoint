// See https://aka.ms/new-console-template for more information

//var data = new string[7] { "ток", "рост", "кот", "торс", "Кто", "фывап", "рок" };

IEnumerable<IEnumerable<string>> Method(string[] data) =>
    data.GroupBy(str => string.Concat(
                str.ToLower()
                    .OrderBy(ch => ch)
            )
            .GetHashCode())
        .Select(gr =>
            gr.Select(elem => elem)
        );
