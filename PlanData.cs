using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NT106
{
    [System.Serializable]
    public class PlanData
    {
        private List<PlanItem> planItems;

        public List<PlanItem> PlanItems
        {
            get { return planItems; }
            set { planItems = value; }
        }
        
        /*Thêm phần có cần Thông báo hay không vào đây để khi Serializable sẽ được load theo luôn mà k cần cài lại*/
    }
}
