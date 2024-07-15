# Guest-Shabbat-Host-App

## Add nuggets
- System.Data.SqlClient
- `ReaLTaiizor`
- `Microsoft.Extensions.Configuration`
- `Microsoft.Extensions.Configuration.UserSecrets`
- `Newtonsoft.Json (debud purposes)`

## Add user secrets
- Right click the csproj and find manage user secrets
- Add: 
```json
{
	"ConnectionString": "{{YOUR_CS}}",
	"DefaultDB": "{{YOUR_DBNAME}}"
}
```
		