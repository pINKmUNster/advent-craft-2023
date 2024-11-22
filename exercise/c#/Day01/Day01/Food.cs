namespace Day01
{
    public record Food(
        DateOnly ExpirationDate,
        bool ApprovedForConsumption,
        Guid? InspectorId)
    {
        public bool IsEdible(Func<DateOnly> now) => IsFresh(now) && CanBeConsumed() && HasBeenInspected();

        private bool CanBeConsumed() => ApprovedForConsumption;

        private bool HasBeenInspected() => InspectorId != null;

        private bool IsFresh(Func<DateOnly> now) => ExpirationDate.IsGreaterThan(now());
    }
}