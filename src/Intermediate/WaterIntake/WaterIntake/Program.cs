using WaterIntake;
using WaterIntake.Data;
using static WaterIntake.Messages;

await DataAccess.CreateWaterIntakeTableAsync();

bool closeApp = false;

while (closeApp == false)
{
    ConsolePrinter.PrintMainMenu();

    ConsolePrinter.PrintMessage(UserMenuChoiceMessage, onSameLine: true);

    string userChoice = ConsoleReader.Utils.GetValidMenuChoiceInput();

    switch (userChoice)
    {
        case "0":
            ConsolePrinter.PrintMessage(GoodbyeMessage);
            closeApp = true;
            break;
        case "1":
            ConsolePrinter.PrintTableRecords(await DataAccess.GetAllRecordsAsync());
            break;
        case "2":
            ConsolePrinter.PrintMessage(InsertDateMessage);
            ConsolePrinter.PrintMessage("Date: ", onSameLine: true);
            string insertDateInput = ConsoleReader.Utils.GetValidDateInput();

            ConsolePrinter.PrintMessage(InsertLitresMessage);
            ConsolePrinter.PrintMessage("Litres: ", onSameLine: true);
            string insertLitresInput = ConsoleReader.Utils.GetValidLitresInput();
            float insertLitres = float.Parse(insertLitresInput);

            int insertRecordRowsAffected = await DataAccess.InsertAsync(insertDateInput, insertLitres);
            ConsolePrinter.PrintDbOperationSuccessOrNot(insertRecordRowsAffected);
            break;
        case "3":
            ConsolePrinter.PrintMessage(InsertRecordId, onSameLine: true);
            string deleteRecordIdInput = ConsoleReader.Utils.GetValidRecordIdInput();
            int deleteRecordId = int.Parse(deleteRecordIdInput);

            int deleteOperationRowsAffected = await DataAccess.DeleteRecordAsync(deleteRecordId);
            ConsolePrinter.PrintDbOperationSuccessOrNot(deleteOperationRowsAffected);
            break;
        case "4":
            ConsolePrinter.PrintMessage(InsertRecordId, onSameLine: true);
            string updateRecordIdInput = ConsoleReader.Utils.GetValidRecordIdInput();
            int recordIdUpdate = int.Parse(updateRecordIdInput);

            ConsolePrinter.PrintMessage($"{InsertDateMessage} Type Enter to remain unchanged.");
            ConsolePrinter.PrintMessage("Date: ", onSameLine: true);
            string updateDateInput = ConsoleReader.Utils.GetValidDateInput(isForUpdate: true);

            ConsolePrinter.PrintMessage($"{InsertLitresMessage} Type Enter to remain unchanged.");
            ConsolePrinter.PrintMessage("Litres: ", onSameLine: true);
            string updateLitresInput = ConsoleReader.Utils.GetValidLitresInput(isForUpdate: true);
            float updateLitres = updateLitresInput == string.Empty ? 0 : float.Parse(updateLitresInput);

            int updateOperationRowsAffected = await DataAccess.UpdateRecordAsync(recordIdUpdate, updateDateInput, updateLitres);
            ConsolePrinter.PrintDbOperationSuccessOrNot(updateOperationRowsAffected);
            break;
        default:
            ConsolePrinter.PrintMessage(InvalidMenuOptionMessage, onSameLine: false, OutputMessageType.Error);
            ConsolePrinter.PrintNewLine();
            break;
    }
}
