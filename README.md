# GarudaUtil

[![License](https://img.shields.io/badge/license-APACHE-red.svg)](http://www.apache.org/licenses/LICENSE-2.0)

[![NuGet Pre Release](https://img.shields.io/nuget/vpre/Garuda.Data.svg)](https://www.nuget.org/packages/Garuda.Data/)

## Garuda.Data

A .NET assembly which provides System.Data interface implementations for [Apache Phoenix](https://phoenix.apache.org/)
 via the [Microsoft.Phoenix.Client](https://www.nuget.org/packages/Microsoft.Phoenix.Client/).

 Classes include:

 * PhoenixConnection implementing IDbConnection
 * PhoenixCommand implementing IDbCommand
 * PhoenixDataReader implementing IDbDataReader
 * PhoenixTransaction implementing IDbTransaction

### Connection string

The familiar connection string format is used for connections:

```
Server=myphoenixserver.domain.com,8765;User ID=myuser;Password=mypwd;CredentialUri=http://myazurecredurl;Request Timeout=30000" 
```

* Credentials are only used by the Microsoft.Phoenix.Client in gateway-mode (Azure), which requires port 443.
* Request Timeout is in milliseconds.

### Example

 Refer the the GarudaUtil Program.cs file for a more complete example.

 ```{csharp}
using (IDbConnection phConn = new PhoenixConnection())
{
    phConn.ConnectionString = cmdLine.ConnectionString;

    phConn.Open();

    using (IDbCommand cmd = phConn.CreateCommand())
    {
        cmd.CommandText = "SELECT * FROM GARUDATEST";
        using (IDataReader reader = cmd.ExecuteReader())
        {
            while(reader.Read())
            {
                for(int i = 0; i < reader.FieldCount; i++)
                {
                    Console.WriteLine(string.Format("{0}: {1}", reader.GetName(i), reader.GetValue(i)));
                }
            }
        }
    }                        
}
```
 
### Transactions

At any given time, only a single transaction is supported on a given connection.  This appears to be a limitation of 
the Phoenix client or Phoenix itself (to be determined). Currently PhoenixConnection.BeginTransaction will allow creation
of > 1 transaction, but which ever is last active wins.

### Parameters

Support for parameters has been added. Refer to the Phoenix documentation for details on usage. Basically,
the question mark (?) and positional (:1) notations are supported as in the following:
 
```
UPSERT INTO GARUDATEST (ID, AircraftIcaoNumber) VALUES (NEXT VALUE FOR garuda.testsequence, :1)
```
 
Initial testing has been successful for string 
parameters, but integer parameters produce a ProtoBuf error. It is unclear if this is an issue with the underlying 
ProtoBuf API (the version we are using is an alpha release), a Phoenix Client issue, or a bug in Garuda.Data.