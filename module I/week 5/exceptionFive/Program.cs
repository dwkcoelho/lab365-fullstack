using exceptions.Class;

    Concert concert = new Concert();
    concert.QuantitySell = 25;
    concert.QuantityPlaces = 20;

    if (concert.QuantityPlaces - concert.QuantitySell > 0)
    {
        Console.WriteLine("Ticket Validated!");
        concert.ticketSold();
    }
    else
    {
        throw new TicketException("There are no more tickets available for the concert.");
    }