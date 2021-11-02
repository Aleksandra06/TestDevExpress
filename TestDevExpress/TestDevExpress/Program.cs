using System;
using System.Collections.Generic;
using TestDevExpress.Core;
using TestDevExpress.Core.Models;

namespace TestDevExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Model model = new Model();
            model.Name = "Vorname";
            model.NameSize = 15;
            model.Blocks = new List<BlockModel>();
            model.Blocks.Add(new BlockModel()
            {
                Text = @"Буря мглою небо кроет,
Вихри снежные крутя;
То, как зверь, она завоет,
То заплачет, как дитя,
То по кровле обветшалой
Вдруг соломой зашумит,
То, как путник запоздалый,
К нам в окошко застучит.",
                Title = "Зимний вечер"
            });
            model.Blocks.Add(new BlockModel()
            {
                Text = @"В тот год осенняя погода
Стояла долго на дворе,
Зимы ждала, ждала природа.
Снег выпал только в январе",
                Title = "В тот год осенняя погода"
            });

            byte[] file =
                new XtraReportEngine().CreateAnschreibenEmpfehlungReport(model,
                    2);

            System.IO.File.WriteAllBytes(@"D:\hello.pdf", file);
        }
    }
}
