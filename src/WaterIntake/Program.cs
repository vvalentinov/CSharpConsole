using static WaterIntake.WaterIntakeDataAccess;
using static WaterIntake.ConsolePrinter;

await CreateWaterIntakeTableAsync();

bool closeApp = false;

while (!closeApp)
{
    PrintMainMenu();
    PrintYourChoiceMessage();

    bool isInputValid = int.TryParse(Console.ReadLine(), out int command);

    while (!isInputValid)
    {
        PrintInvalidMenuOptionError();
        PrintMainMenu();
        PrintYourChoiceMessage();
        isInputValid = int.TryParse(Console.ReadLine(), out command);
    }

    switch (command)
    {
        case 0:
            PrintGoodbyeMessage();
            closeApp = true;
            break;
        case 1:
            await GetAllRecordsAsync();
            break;
        case 2:
            await InsertAsync();
            break;
        case 3:
            await DeleteRecordAsync();
            break;
        case 4:
            await UpdateRecordAsync();
            break;
        default:
            PrintInvalidMenuOptionError();
            break;
    }
}
