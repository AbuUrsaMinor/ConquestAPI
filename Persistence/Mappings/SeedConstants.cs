using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Persistence.Mappings
{
    class SeedConstants
    {
        public static readonly Coordinate stockholm1 = new Coordinate(new Guid("90774271-F4C5-409D-B51C-B02C9E2B781F"), 59.47794625880653, 17.787542935493313);
        public static readonly Coordinate stockholm2 = new Coordinate(new Guid("0A5F126D-9997-4DAF-8020-345934D284CD"), 59.46643631959409, 18.487921300999744);
        public static readonly Coordinate stockholm3 = new Coordinate(new Guid("053411FE-6184-4D24-90BA-A22DC30169D3"), 59.07707333413526, 18.474954897944063);
        public static readonly Coordinate stockholm4 = new Coordinate(new Guid("990E250A-0F0C-455E-9162-636CE33FE346"), 59.1782238765677, 17.709756952714102);

        public static readonly Coordinate solna1 = new Coordinate(new Guid("CEFA7D5E-C6A2-447D-97A0-5F29343B3C15"), 59.38646807507921, 17.97526084217001);
        public static readonly Coordinate solna2 = new Coordinate(new Guid("7DB52C29-547F-4C68-BD11-C298520AF633"), 59.37213075392674, 18.037186749665644);
        public static readonly Coordinate solna3 = new Coordinate(new Guid("EC607AF0-3D97-4DEC-85BF-153B9D114B92"), 59.35101813051987, 18.05162169313782);
        public static readonly Coordinate solna4 = new Coordinate(new Guid("0DD216C9-CA94-4B3B-8E20-E75AB7A87A93"), 59.34844252171261, 17.975116492735285);

        public static readonly Coordinate sodermalm1 = new Coordinate(new Guid("2BC8C8EB-73EF-4CD8-99EC-C366F2077F63"), 59.32319121325237, 18.02506139796964);
        public static readonly Coordinate sodermalm2 = new Coordinate(new Guid("746A5C3D-F239-41A0-83F8-DCC9A74F8636"), 59.31729899568982, 18.10936146784715);
        public static readonly Coordinate sodermalm3 = new Coordinate(new Guid("FFE63975-16BF-4252-B5A1-5A8501D53CC9"), 59.302195525730475, 18.076161097861142);
        public static readonly Coordinate sodermalm4 = new Coordinate(new Guid("EA93B9C7-9621-4E03-9AEC-8CB1AD1B8094"), 59.31538380506497, 18.023762253057146);

        public static readonly Coordinate kista1 = new Coordinate(new Guid("602BBA97-12AB-4736-BC7D-412E07C07AAB"), 59.39220130728089, 17.948989244576598);
        public static readonly Coordinate kista2 = new Coordinate(new Guid("BF75248E-7A70-4B21-9164-2D70B688B835"), 59.40528120449777, 17.922717647457233);
        public static readonly Coordinate kista3 = new Coordinate(new Guid("B19DFC33-EE99-4C5B-AE6D-276C1CA937EF"), 59.41424316210853, 17.940039579623843);
        public static readonly Coordinate kista4 = new Coordinate(new Guid("225EE1CE-DB68-4B9C-94C0-4CFC35948782"), 59.39844795543539, 17.97641563717373);

        public static readonly Region stockholm = new Region(new Guid("921225c3-3253-470d-8dbf-df1f130dec93"), "Stockholm", null, true, new Coordinate[] { });
        public static readonly Region solna = new Region(new Guid("953A7054-36C8-4A80-897B-52CD16115925"), "Solna", stockholm, true, new Coordinate[] { });
        public static readonly Region sodermalm = new Region(new Guid("3CFED5D0-0BA6-47D7-8F23-DCB912751016"), "Södermalm", stockholm, true, new Coordinate[] { });
        public static readonly Region kista = new Region(new Guid("6651AFDF-5ADA-4CFA-B55D-03AE6D8618D8"), "Kista", stockholm, false, new Coordinate[] { });

    }
}
