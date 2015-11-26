using UnityEngine;
using System.Collections;
using UniRx;

public class IntroController : ObservableMonoBehaviour
{
    public override void Awake()
    {
		// Intro Scene >>(3s)>> Stage Scene
        Observable.Timer(System.TimeSpan.FromSeconds(3f))
            .Subscribe(_ =>
            {
                Application.LoadLevel("Stage");
            });

        base.Awake();
    }
}
