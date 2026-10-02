using System; //도구 상자
using System.Collections.Generic; //이거 없으면 도구 상자 못씀
using System.Linq;

using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.ApplicationServices;

namespace seowoo92
{
    public class Command : IExternalCommand //아이~(계약서 이름) 인터페이스를 상속 받아서 구현한다는 뜻
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            Application app = commandData.Application.Application;
            UIDocument uiDoc = commandData.Application.ActiveUIDocument;
            Document doc = uiDoc.Document;

            // 깃 깃헙 업데이트 테스트


            return Result.Succeeded;
        }
    }
}
