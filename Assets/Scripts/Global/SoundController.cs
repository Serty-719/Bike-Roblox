using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    [SerializeField] private AudioSource[] _musicSources;
    [SerializeField] private AudioSource[] _effectSources;
    [SerializeField] private AudioClip _buyClip;
    [SerializeField] private AudioClip _equipClip;
    [SerializeField] private AudioClip _moneyIncreaseSound;
    [SerializeField] private AudioClip _clickSound;
    [SerializeField] private AudioClip _boostSound;
    private void Start()
    {
        ShopItemData.OnItemBought += PlayBuySound;
        ShopItemData.OnItemEquiped += PlayEquipSound;
        BankVolute.OnMoneyIncrease += PlayMoneyIncreaseSound;
    }
    private void OnDestroy()
    {
        ShopItemData.OnItemBought -= PlayBuySound;
        ShopItemData.OnItemEquiped -= PlayEquipSound;
        BankVolute.OnMoneyIncrease -= PlayMoneyIncreaseSound;
    }
    public void MusicVolume(Slider volumeSlider)
    {
        foreach (var source in _musicSources)
        {
            source.volume = volumeSlider.value / volumeSlider.maxValue;
        }
    }
    public void EffectVolume(Slider volumeSlider)
    {
        foreach (var source in _effectSources)
        {
            source.volume = volumeSlider.value / volumeSlider.maxValue;
        }
    }
    public void PlayBuySound()
    {
        _effectSources[0].clip = _buyClip;
        _effectSources[0].Play();
    }
    public void PlayEquipSound()
    {
        _effectSources[0].clip = _equipClip;
        _effectSources[0].Play();
    }
    public void PlayMoneyIncreaseSound()
    {
        _effectSources[0].clip = _moneyIncreaseSound;
        _effectSources[0].Play();
    }
    public void PlayClickSound()
    {
        _effectSources[1].clip = _clickSound;
        _effectSources[1].Play();
    }
    public void PlayBoostSound()
    {
        _effectSources[0].clip = _boostSound;
        _effectSources[0].Play();
    }
}