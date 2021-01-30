using CefSharp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MASM_SCAU
{
    class Messback
    {
        public string Mes = "";

    }
    class JsEvent
    {
        /// <summary>
        /// js里的方法
        /// </summary>
        /// <param name="javascriptCallback">js回调</param>
        public void playClick(IJavascriptCallback javascriptCallback)
        {
            Task.Factory.StartNew(async () =>
            {
                using (javascriptCallback)
                {
                    //Do something call by js
                    Messback msb = new Messback();
                    string response = JsonConvert.SerializeObject(
                        new
                        { msg = msb.Mes }
                    );
                    await javascriptCallback.ExecuteAsync(response);
                }
            });

        }
    }
}
