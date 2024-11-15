# OTOAUTO - Ogłoszenia Pojazdów i Części

**Autorzy**: Dominik Pacanowski, Konrad Paulus

OTOAUTO to aplikacja internetowa typu MVC w języku polskim oparta na platformie .NET 8, stworzona do ogłoszeń pojazdów i części samochodowych. Platforma oferuje kompletny system uwierzytelniania użytkowników, umożliwiając rejestrację jako sprzedawca lub kupujący. Sprzedawcy mogą publikować ogłoszenia pojazdów i części, zarządzać swoimi ogłoszeniami i kontaktować się z potencjalnymi kupującymi. Kupujący mogą przeglądać ogłoszenia i kontaktować się ze sprzedawcami.

## Użyte technologie
- **Backend**: .NET 8 (ASP.NET MVC)
- **Baza danych**: SQL Server (skonfigurowany za pomocą Entity Framework Core w podejściu Code-First)
- **Uwierzytelnianie**: Uwierzytelnianie oparte na ciasteczkach z ASP.NET Identity i haszowaniem haseł
- **Frontend**: Strony Razor oraz Bootstrap (do stylizacji)

## Uruchamianie projektu lokalnie

Wymagania: .NET 8 SDK (potrzebne do kompilacji i uruchomienia aplikacji).

1. **Sklonuj repozytorium**:
   ```bash
   git clone https://github.com/pacanowsky/Projekt_OtoAuto/
   ```

2. **Połączenie z bazą danych**:
   - Otwórz plik `appsettings.json` i zaktualizuj ciąg połączenia, aby wskazywał na instancję SQL Server.

3. **Aktualizacja bazy danych**:
   - Przejdź do **Narzędzia > Menedżer pakietów NuGet > Konsola Menedżera pakietów**.
   - Uruchom poniższą komendę, aby utworzyć bazę danych i zastosować migracje:
     ```bash
     update-database
     ```

4. **Uruchom projekt**:
   - Naciśnij `F5` lub wybierz **Uruchom**, aby rozpoczać projekt na lokalnym serwerze.

## Struktura projektu
- **Controllers**: Zawiera główną logikę dla każdej jednostki.
- **Models**: Definiuje strukturę danych aplikacji (np. `Listing`, `User`).
- **Views**: Widoki Razor do renderowania interfejsu użytkownika.
- **Migrations**: Zawiera pliki migracji do inicjalizacji i aktualizacji schematu bazy danych.

## Modele

Każdy model reprezentuje tabelę bazy danych w SQL Server.

1. **Model Part**
   - Reprezentuje część samochodową dostępną jako osobne ogłoszenie.
   - Pola: `Id`, `PartName`, `PartNumber`, `Condition`, `ListingId`.

2. **Model Category**
   - Reprezentuje kategorię ogłoszeń, np. Samochód, Ciężarówka, Motocykl.
   - Pola: `Id`, `Name`, `Listings`.

3. **Model Listing**
   - Reprezentuje ogłoszenie na sprzedaż pojazdu lub części.
   - Pola: `Id`, `Title`, `Description`, `Price`, `PostedDate`, `IsSold`, `IsFeatured`, `IsActive`, `CreatedAt`, `UpdatedAt`, `UserId`, `CategoryId`, `Vehicle`, `Part`, `Transaction`, `Images`, `StaticImagePath`.

4. **Model Image**
   - Reprezentuje obraz powiązany z ogłoszeniem.
   - Pola: `Id`, `Url`, `ListingId`.

5. **Model Transaction**
   - Reprezentuje transakcję zakupu.
   - Pola: `Id`, `TransactionDate`, `Amount`, `ListingId`, `BuyerId`.

6. **Model User**
   - Reprezentuje użytkownika systemu, zarówno sprzedawcę, jak i kupującego.
   - Pola: `Id`, `Username`, `Email`, `PasswordHash`, `PhoneNumber`, `UserType`, `Listings`, `Transactions`.

7. **Model Vehicle**
   - Reprezentuje pojazd na sprzedaż.
   - Pola: `Id`, `Make`, `Model`, `Year`, `VIN`, `Mileage`, `FirstRegistration`, `EngineCapacity`, `ListingId`.

## Modele Widoków (ViewModels)

1. **CreateListingViewModel**: Używany do tworzenia nowego ogłoszenia. Pola obejmują `Title`, `Description`, `Price`, `CategoryId`, `Images`, oraz opcjonalne informacje o pojeździe.

2. **EditListingViewModel**: Używany do edycji istniejącego ogłoszenia. Pola obejmują `Id`, `Title`, `Description`, `Price`, `Images`, `NewImages`.

3. **ErrorViewModel**: Używany do przechowywania informacji o błędach. Pola: `RequestId`, `ShowRequestId`.

4. **HomeViewModel**: Używany do wyświetlania zawartości strony głównej. Pola: `FeaturedListings`, `Listings`, `SearchTerm`.

5. **LoginViewModel**: Używany do logowania użytkowników. Pola: `Email`, `Password`.

6. **RegisterViewModel**: Używany do rejestracji nowych użytkowników. Pola: `Email`, `Password`, `ConfirmPassword`, `UserType`, `PhoneNumber`.

## Kontrolery

1. **AccountController**: Zarządza procesami logowania, rejestracji i wylogowania użytkowników. Metody: `Login`, `Register`, `Logout`.

2. **HomeController**: Obsługuje stronę główną, szczegóły ogłoszenia i inne widoki publiczne. Metody: `Index`, `Details`.

3. **SellingController**: Obsługuje zarządzanie ogłoszeniami sprzedawcy. Metody: `Index`, `MyListings`, `Create`, `Edit`, `Delete`.

## System użytkowników

Aplikacja OTOAUTO wspiera dwie główne role użytkowników:

- **Sprzedawca**: Może tworzyć, edytować i usuwać ogłoszenia, przeglądać swoje ogłoszenia oraz zarządzać nimi.
- **Kupujący**: Może przeglądać ogłoszenia oraz kontaktować się ze sprzedawcami.

## Charakterystyka najciekawszych funkcjonalności

- **System zarządzania zdjęciami**: Użytkownicy mogą dodawać do 10 zdjęć do każdego ogłoszenia.
- **Wyszukiwanie i filtrowanie ogłoszeń**: Przeszukiwanie ogłoszeń na podstawie słów kluczowych.
- **Rozbudowane informacje o pojazdach**: Szczegółowe informacje takie jak Przebieg, Pojemność silnika, Rok produkcji.
- **Wyświetlanie szczegółów tylko dla zalogowanych**: Dane kontaktowe sprzedawcy są ukryte przed niezalogowanymi użytkownikami.

## Zdjęcia oraz krótki opis działania

1. **Strona główna (Index)**: Wyświetla listę wyróżnionych ogłoszeń oraz wszystkie dostępne ogłoszenia. Umożliwia wyszukiwanie na podstawie słów kluczowych.

2. **Rejestracja użytkownika (Register)**: Umożliwia założenie konta jako "Sprzedawca" lub "Kupujący". Walidacja pól takich jak email, hasło i numer telefonu.

3. **Logowanie użytkownika (Login)**: Umożliwia zalogowanie za pomocą adresu email i hasła. Sprawdza poprawność danych logowania i zapisuje sesję.

4. **Dodawanie nowego ogłoszenia (Create)**: Pozwala sprzedawcy utworzyć nowe ogłoszenie, w tym dodanie tytułu, opisu, ceny, kategorii i zdjęć.

5. **Edycja ogłoszenia (Edit)**: Umożliwia edytowanie istniejącego ogłoszenia, usuwanie zdjęć, aktualizację szczegółów.

6. **Usuwanie ogłoszenia (Delete)**: Wyświetla potwierdzenie usunięcia ogłoszenia. Po akceptacji usuwa ogłoszenie wraz z jego zdjęciami.

7. **Moje ogłoszenia (MyListings)**: Wyświetla listę ogłoszeń należących do zalogowanego sprzedawcy. Pozwala zarządzać ogłoszeniami (edytować, usuwać).

---
Czy chcesz, abym dodał/a jakieś dodatkowe sekcje, takie jak licencja, sposób zgłaszania błędów lub kontakt? Możesz też wskazać, jeśli jakieś elementy wymagają bardziej szczegółowego opisu.

