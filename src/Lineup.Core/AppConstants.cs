namespace Lineup.Core;

/// <summary>
/// Shared application-wide constants and default values.
/// </summary>
public static class AppConstants
{
    /// <summary>
    /// Default SQLite database filename for EPG cache.
    /// </summary>
    public const string DefaultDatabaseFileName = "lineup_cache.db";

    /// <summary>
    /// Default HDHomeRun device hostname used when no address is configured.
    /// </summary>
    public const string DefaultDeviceAddress = "hdhomerun.local";

    /// <summary>
    /// Default filename for the generated XMLTV file.
    /// </summary>
    public const string DefaultXmltvFileName = "epg.xml";

    /// <summary>
    /// Default directory path for the generated XMLTV file.
    /// </summary>
    public const string DefaultXmltvFilePath = "xmltv";

    /// <summary>
    /// Filename for persisted application settings.
    /// </summary>
    public const string SettingsFileName = "settings.json";

    /// <summary>
    /// Configuration key for the application config path.
    /// </summary>
    public const string ConfigPathConfigKey = "Lineup:ConfigPath";

    /// <summary>
    /// Configuration key for the XMLTV output path.
    /// </summary>
    public const string XmltvPathConfigKey = "Lineup:XmltvPath";

    /// <summary>
    /// Environment variable name for the device address.
    /// </summary>
    public const string DeviceAddressEnvVar = "Lineup__DeviceAddress";

    /// <summary>
    /// Environment variable name for the database path.
    /// </summary>
    public const string DatabasePathEnvVar = "Lineup__DatabasePath";

    /// <summary>
    /// Configuration key for the HTTP port.
    /// </summary>
    public const string HttpPortConfigKey = "Lineup:HttpPort";

    /// <summary>
    /// Configuration key for the HTTPS port.
    /// </summary>
    public const string HttpsPortConfigKey = "Lineup:HttpsPort";

    /// <summary>
    /// Default HTTP port.
    /// </summary>
    public const int DefaultHttpPort = 8080;

    /// <summary>
    /// Default HTTPS port.
    /// </summary>
    public const int DefaultHttpsPort = 8443;

    /// <summary>
    /// Configuration key for the HTTPS certificate (.pfx) file path.
    /// Intentionally not under the reserved "Kestrel:Certificates:Default" key: Kestrel binds that
    /// section automatically on every startup and validates it eagerly, which would crash the app
    /// on missing-certificate even when HTTPS is meant to be optional. Using our own key keeps the
    /// File.Exists check in Program.cs as the sole gate for enabling HTTPS.
    /// </summary>
    public const string CertPathConfigKey = "Lineup:CertPath";

    /// <summary>
    /// Configuration key for the HTTPS certificate (.pfx) password.
    /// </summary>
    public const string CertPasswordConfigKey = "Lineup:CertPassword";

    /// <summary>
    /// XMLTV episode numbering system identifier.
    /// </summary>
    public const string XmltvNsSystem = "xmltv_ns";
}
