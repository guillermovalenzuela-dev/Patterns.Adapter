using Patterns.Adapter;

INewInterface adapter = new Adapter();
adapter.NewMethod(); // This calls the legacy method via the adapter.
