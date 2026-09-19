# Gujarati Test API

A minimal ASP.NET Core API that returns three fixed Gujarati answer strings for testing the Unity HarfBuzz bridge.

## Requirements
- .NET 8 SDK (or newer compatible SDK)

## Run locally
From this folder:

```bash
dotnet restore
dotnet run --urls http://0.0.0.0:5080
```

Then open:

- `http://localhost:5080/api/answers`

Expected JSON:

```json
{
  "answers": [
    { "text": "કૃપા" },
    { "text": "આકાશ" },
    { "text": "આત્મવિશ્વાસ" }
  ]
}
```

## Unity note
`localhost` from an Android device refers to the device itself, not your development PC.
For a device test, use your PC's LAN IP (for example `http://192.168.1.20:5080/api/answers`) and ensure the phone and PC are on the same network and the firewall allows port 5080.

For an Android build, cleartext HTTP may be blocked depending on your Unity/Android configuration. Prefer HTTPS for anything beyond local development.
