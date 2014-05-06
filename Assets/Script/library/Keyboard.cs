using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Library
{
    class Keyboard
    {
        /// <summary>
        /// 押されたキー名称を文字列型で返します。
        /// </summary>
        /// <returns>押されたキー名称</returns>
        public string getKeyDown(){
            // キーボード操作を取得するときは便利
            if (Input.GetKeyDown(KeyCode.A)) return KeyCode.A.ToString();
            if (Input.GetKeyDown(KeyCode.B)) return KeyCode.B.ToString();
            if (Input.GetKeyDown(KeyCode.C)) return KeyCode.C.ToString();
            if (Input.GetKeyDown(KeyCode.D)) return KeyCode.D.ToString();
            if (Input.GetKeyDown(KeyCode.E)) return KeyCode.E.ToString();
            if (Input.GetKeyDown(KeyCode.F)) return KeyCode.F.ToString();
            if (Input.GetKeyDown(KeyCode.G)) return KeyCode.G.ToString();
            if (Input.GetKeyDown(KeyCode.H)) return KeyCode.H.ToString();
            if (Input.GetKeyDown(KeyCode.I)) return KeyCode.I.ToString();
            if (Input.GetKeyDown(KeyCode.J)) return KeyCode.J.ToString();
            if (Input.GetKeyDown(KeyCode.K)) return KeyCode.K.ToString();
            if (Input.GetKeyDown(KeyCode.L)) return KeyCode.L.ToString();
            if (Input.GetKeyDown(KeyCode.M)) return KeyCode.M.ToString();
            if (Input.GetKeyDown(KeyCode.N)) return KeyCode.N.ToString();
            if (Input.GetKeyDown(KeyCode.O)) return KeyCode.O.ToString();
            if (Input.GetKeyDown(KeyCode.P)) return KeyCode.P.ToString();
            if (Input.GetKeyDown(KeyCode.Q)) return KeyCode.Q.ToString();
            if (Input.GetKeyDown(KeyCode.R)) return KeyCode.R.ToString();
            if (Input.GetKeyDown(KeyCode.S)) return KeyCode.S.ToString();
            if (Input.GetKeyDown(KeyCode.T)) return KeyCode.T.ToString();
            if (Input.GetKeyDown(KeyCode.U)) return KeyCode.U.ToString();
            if (Input.GetKeyDown(KeyCode.V)) return KeyCode.V.ToString();
            if (Input.GetKeyDown(KeyCode.W)) return KeyCode.W.ToString();
            if (Input.GetKeyDown(KeyCode.X)) return KeyCode.X.ToString();
            if (Input.GetKeyDown(KeyCode.Y)) return KeyCode.Y.ToString();
            if (Input.GetKeyDown(KeyCode.Z)) return KeyCode.Z.ToString();

            if (Input.GetKeyDown(KeyCode.Space)) return KeyCode.Space.ToString();
            if (Input.GetKeyDown(KeyCode.Return)) return KeyCode.Return.ToString();
            if (Input.GetKeyDown(KeyCode.Escape)) return KeyCode.Escape.ToString();
            if (Input.GetKeyDown(KeyCode.Tab)) return KeyCode.Tab.ToString();
            if (Input.GetKeyDown(KeyCode.Backspace)) return KeyCode.Backspace.ToString();

            // 押されなかった場合
            return "";

        }
    }
}
