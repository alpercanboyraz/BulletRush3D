# BulletRush3D


## Oyun Mantığı
```
Enemyler spawn edildikten sonra playerın üzerine gelmektedir bu durum navmesh ile gerçekleşmektedir.
```
```
Player hareketleri için Touch Input kullanılmıştır.
```

```
Player bir range'e sahiptir.Playerın range'ine enemyler girdiğinde animasyon değişir ve otomatik ateş etmeye başlar.
```


## Projede geliştirilebilir durumlar 

- Object Pool Pattern(Projede Şu an mermiler Instantiate olduktan 2 saniye sonra yok olmaktadır.Bu durum object pooling pattern ile daha optimize çalışabilir.)
+Idle Animation &nbsp;
+Cinemachine &nbsp;
+Big enemy'nin player'ın arkasından saldırı yapması &nbsp;
-Bu durumlar deadline süresinden dolayı yetiştirelememiştir.

## Çözülemeyen buglar

+Spawn edilen enemyler bazen navmesh'in bake ettiği alanın sınırlarında takılı kalmaktadır.
