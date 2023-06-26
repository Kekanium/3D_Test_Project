using UnityEngine;
namespace Menu {
    public class MenuScript : MonoBehaviour {
        public void SwitchToCoin() {
            SceneTransition.SwitchToScene("CoinScene");
        }
        public void SwitchToCar() {
            SceneTransition.SwitchToScene("CarScene");
        }
    }
}