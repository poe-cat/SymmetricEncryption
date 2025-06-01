# Symmetric Encryption App

A Windows Forms application written in C# that allows users to encrypt and decrypt text using various symmetric encryption algorithms (AES, DES, TripleDES, RC2).

## Features

- Selectable encryption algorithm (via ComboBox)
- Key and IV (initialization vector) generation
- Plaintext input (ASCII)
- Display of encrypted output in:
  - ASCII
  - HEX
- Decryption back to plaintext
- Time measurement for encryption and decryption (in milliseconds)

## Supported Algorithms

- AES
- DES
- TripleDES
- RC2

## Interface Overview

| Element            | Description                                              |
|--------------------|----------------------------------------------------------|
| ComboBox           | Selects encryption algorithm                             |
| Generate Key & IV  | Auto-generates secure Key and IV for selected algorithm  |
| PlainText (ASCII)  | Text to be encrypted (input)                             |
| CipherText (ASCII) | Resulting encrypted message in ASCII                     |
| CipherText (HEX)   | Encrypted message in hexadecimal format                  |
| Encryption Time    | Duration of encryption process                           |
| Decryption Time    | Duration of decryption process                           |

## How It Works

1. Select an encryption algorithm.
2. Click "Generate Key and IV" to generate cryptographic parameters.
3. Enter your message in the PlainText field.
4. Click "Encrypt" — encrypted output will appear.
5. Click "Decrypt" — if the ciphertext is valid, the original message will be restored.

## Requirements

- .NET 7 SDK (https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
- Visual Studio 2022 or newer with .NET Desktop Development workload

## Notes

- The application uses ASCII encoding. Non-ASCII characters may not display correctly.
- Keys and IVs are displayed in hexadecimal.
- You must encrypt and decrypt using the same algorithm, Key, and IV.

## Project Structure

```
SymmetricEncryptionApp/
├── Form1.cs             # Logic and event handling
├── Form1.Designer.cs    # UI layout and control setup
├── Program.cs           # Application entry point
├── SymmetricEncryptionApp.csproj
```

## Future Improvements

- Support for Base64 encoding
- Import/export Key and IV
- Saving encrypted messages to file
- Validation and error messages

Created for educational purposes in .NET WinForms.
