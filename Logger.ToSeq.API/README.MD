# Serilog

## Veritaban� kay�t i�lemleri
--  LogFilter dosyas� �zerinden DI ve ServiceProvider y�ntemi ile ger�ekle�tirildi

## Docker Kurulum Kodu
```
docker run --name seq -d --restart unless-stopped -e ACCEPT_EULA=Y -p 5341:80 datalust/seq
```