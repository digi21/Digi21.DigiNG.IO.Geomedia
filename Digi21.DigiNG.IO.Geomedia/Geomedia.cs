using System;
using System.Collections;
using System.Collections.Generic;
using Digi21.DigiNG.Entities;
using Digi21.Tasks;

namespace Digi21.DigiNG.IO.Geomedia
{
    public class Geomedia : IDrawingFile, IDisposable
    {
        public event ProgressEventHandler ProgressChanged;
        public event ResultsAddedEventHandler ResultsAdded;
        public event TaskAddedEventHandler TaskAdded;

        public Geomedia(string path) => throw null;
        public Geomedia(string path, DigiTab.DigiTab digiTab) => throw null;
        public Geomedia(string path, DelegateGetWkt GetWkt) => throw null;
        public Geomedia(string path, bool readOnly) => throw null;
        public Geomedia(string path, DigiTab.DigiTab digiTab, DelegateGetWkt GetWkt) => throw null;
        public Geomedia(string path, DigiTab.DigiTab digiTab, bool readOnly) => throw null;
        public Geomedia(string path, DelegateGetWkt GetWkt, bool readOnly) => throw null;
        public Geomedia(string path, DigiTab.DigiTab digiTab, DelegateGetWkt GetWkt, bool readOnly) => throw null;
        public ReadOnlyComplex Add(Complex complex) => throw null;
        public void Add(Entity entity) => throw null;
        public ReadOnlyLine Add(Line line) => throw null;
        public ReadOnlyPoint Add(Point point) => throw null;
        public ReadOnlyPolygon Add(Polygon polygon) => throw null;
        public ReadOnlyText Add(Text text) => throw null;
        public void Add(IEnumerable<Entity> entities) => throw null;
        public void Add(Entity entity, IDictionary<string, IDictionary<string, object>> databaseAttributes) => throw null;
        public void Delete(Entity entity) => throw null;
        public void Delete(IEnumerable<Entity> entities) => throw null;
        public void Dispose() => throw null;
        public IDictionary<string, IDictionary<string, object>> GetDatabaseAttributes(Entity entity) => throw null;
        public IEnumerator<Entity> GetEnumerator() => throw null;
        IEnumerator IEnumerable.GetEnumerator() => throw null;
        public string Wkt => throw null;
        public IDictionary<string, int> DatabaseTables => throw null;
        public bool CanWrite => throw null;
        public bool CanRead => throw null;
        public string Path => throw null;
    }
}
