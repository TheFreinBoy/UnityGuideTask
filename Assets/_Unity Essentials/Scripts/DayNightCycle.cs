using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Header("Sun settings")]
    public Light sun;                // Солнце (Directional Light)
    public float dayLength = 120f;  // Длительность дня в секундах

    [Header("Intensity settings")]
    public float maxIntensity = 1f;
    public float minIntensity = 0f;

    private float timeOfDay = 0f;

    void Update()
    {
        // увеличиваем время
        timeOfDay += Time.deltaTime / dayLength;
        timeOfDay %= 1f;

        // вращаем солнце
        float sunAngle = timeOfDay * 360f - 90f;
        sun.transform.rotation = Quaternion.Euler(sunAngle, 170f, 0);

        // меняем яркость солнца
        float intensityMultiplier = Mathf.Clamp01(Mathf.Sin(timeOfDay * Mathf.PI));

        sun.intensity = Mathf.Lerp(minIntensity, maxIntensity, intensityMultiplier);
    }
}