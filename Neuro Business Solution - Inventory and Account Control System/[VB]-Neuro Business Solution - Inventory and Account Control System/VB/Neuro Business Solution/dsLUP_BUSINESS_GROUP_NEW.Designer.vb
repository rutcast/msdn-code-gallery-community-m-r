﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.42
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System


<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"),  _
 Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.ComponentModel.ToolboxItem(true),  _
 System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema"),  _
 System.Xml.Serialization.XmlRootAttribute("dsLUP_BUSINESS_GROUP_NEW"),  _
 System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")>  _
Partial Public Class dsLUP_BUSINESS_GROUP_NEW
    Inherits System.Data.DataSet
    
    Private tableV_BUSINESS_GROUP As V_BUSINESS_GROUPDataTable
    
    Private _schemaSerializationMode As System.Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Sub New()
        MyBase.New
        Me.BeginInit
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
        AddHandler MyBase.Relations.CollectionChanged, schemaChangedHandler
        Me.EndInit
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Sub New(ByVal info As System.Runtime.Serialization.SerializationInfo, ByVal context As System.Runtime.Serialization.StreamingContext)
        MyBase.New(info, context, false)
        If (Me.IsBinarySerialized(info, context) = true) Then
            Me.InitVars(false)
            Dim schemaChangedHandler1 As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
            AddHandler Me.Tables.CollectionChanged, schemaChangedHandler1
            AddHandler Me.Relations.CollectionChanged, schemaChangedHandler1
            Return
        End If
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(String)),String)
        If (Me.DetermineSchemaSerializationMode(info, context) = System.Data.SchemaSerializationMode.IncludeSchema) Then
            Dim ds As System.Data.DataSet = New System.Data.DataSet
            ds.ReadXmlSchema(New System.Xml.XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("V_BUSINESS_GROUP")) Is Nothing) Then
                MyBase.Tables.Add(New V_BUSINESS_GROUPDataTable(ds.Tables("V_BUSINESS_GROUP")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.ReadXmlSchema(New System.Xml.XmlTextReader(New System.IO.StringReader(strSchema)))
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property V_BUSINESS_GROUP() As V_BUSINESS_GROUPDataTable
        Get
            Return Me.tableV_BUSINESS_GROUP
        End Get
    End Property
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.ComponentModel.BrowsableAttribute(true),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Visible)>  _
    Public Overrides Property SchemaSerializationMode() As System.Data.SchemaSerializationMode
        Get
            Return Me._schemaSerializationMode
        End Get
        Set
            Me._schemaSerializationMode = value
        End Set
    End Property
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
    Public Shadows ReadOnly Property Tables() As System.Data.DataTableCollection
        Get
            Return MyBase.Tables
        End Get
    End Property
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
    Public Shadows ReadOnly Property Relations() As System.Data.DataRelationCollection
        Get
            Return MyBase.Relations
        End Get
    End Property
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Sub InitializeDerivedDataSet()
        Me.BeginInit
        Me.InitClass
        Me.EndInit
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Overrides Function Clone() As System.Data.DataSet
        Dim cln As dsLUP_BUSINESS_GROUP_NEW = CType(MyBase.Clone,dsLUP_BUSINESS_GROUP_NEW)
        cln.InitVars
        cln.SchemaSerializationMode = Me.SchemaSerializationMode
        Return cln
    End Function
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As System.Xml.XmlReader)
        If (Me.DetermineSchemaSerializationMode(reader) = System.Data.SchemaSerializationMode.IncludeSchema) Then
            Me.Reset
            Dim ds As System.Data.DataSet = New System.Data.DataSet
            ds.ReadXml(reader)
            If (Not (ds.Tables("V_BUSINESS_GROUP")) Is Nothing) Then
                MyBase.Tables.Add(New V_BUSINESS_GROUPDataTable(ds.Tables("V_BUSINESS_GROUP")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.ReadXml(reader)
            Me.InitVars
        End If
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New System.Xml.XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New System.Xml.XmlTextReader(stream), Nothing)
    End Function
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Friend Overloads Sub InitVars()
        Me.InitVars(true)
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Friend Overloads Sub InitVars(ByVal initTable As Boolean)
        Me.tableV_BUSINESS_GROUP = CType(MyBase.Tables("V_BUSINESS_GROUP"),V_BUSINESS_GROUPDataTable)
        If (initTable = true) Then
            If (Not (Me.tableV_BUSINESS_GROUP) Is Nothing) Then
                Me.tableV_BUSINESS_GROUP.InitVars
            End If
        End If
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Private Sub InitClass()
        Me.DataSetName = "dsLUP_BUSINESS_GROUP_NEW"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/dsLUP_BUSINESS_GROUP_NEW.xsd"
        Me.EnforceConstraints = true
        Me.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        Me.tableV_BUSINESS_GROUP = New V_BUSINESS_GROUPDataTable
        MyBase.Tables.Add(Me.tableV_BUSINESS_GROUP)
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Private Function ShouldSerializeV_BUSINESS_GROUP() As Boolean
        Return false
    End Function
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Shared Function GetTypedDataSetSchema(ByVal xs As System.Xml.Schema.XmlSchemaSet) As System.Xml.Schema.XmlSchemaComplexType
        Dim ds As dsLUP_BUSINESS_GROUP_NEW = New dsLUP_BUSINESS_GROUP_NEW
        Dim type As System.Xml.Schema.XmlSchemaComplexType = New System.Xml.Schema.XmlSchemaComplexType
        Dim sequence As System.Xml.Schema.XmlSchemaSequence = New System.Xml.Schema.XmlSchemaSequence
        xs.Add(ds.GetSchemaSerializable)
        Dim any As System.Xml.Schema.XmlSchemaAny = New System.Xml.Schema.XmlSchemaAny
        any.Namespace = ds.Namespace
        sequence.Items.Add(any)
        type.Particle = sequence
        Return type
    End Function
    
    Public Delegate Sub V_BUSINESS_GROUPRowChangeEventHandler(ByVal sender As Object, ByVal e As V_BUSINESS_GROUPRowChangeEvent)
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"),  _
     System.Serializable(),  _
     System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>  _
    Partial Public Class V_BUSINESS_GROUPDataTable
        Inherits System.Data.DataTable
        Implements System.Collections.IEnumerable
        
        Private columnnID As System.Data.DataColumn
        
        Private columnsGROUP_NAME As System.Data.DataColumn
        
        Private columnsGROUP_DEALER As System.Data.DataColumn
        
        Private columnSTATUS As System.Data.DataColumn
        
        Private columnsBUSINESS_NAME As System.Data.DataColumn
        
        Private columnOPEN_BAL As System.Data.DataColumn
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub New()
            MyBase.New
            Me.TableName = "V_BUSINESS_GROUP"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Friend Sub New(ByVal table As System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Sub New(ByVal info As System.Runtime.Serialization.SerializationInfo, ByVal context As System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property nIDColumn() As System.Data.DataColumn
            Get
                Return Me.columnnID
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property sGROUP_NAMEColumn() As System.Data.DataColumn
            Get
                Return Me.columnsGROUP_NAME
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property sGROUP_DEALERColumn() As System.Data.DataColumn
            Get
                Return Me.columnsGROUP_DEALER
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property STATUSColumn() As System.Data.DataColumn
            Get
                Return Me.columnSTATUS
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property sBUSINESS_NAMEColumn() As System.Data.DataColumn
            Get
                Return Me.columnsBUSINESS_NAME
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property OPEN_BALColumn() As System.Data.DataColumn
            Get
                Return Me.columnOPEN_BAL
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Default ReadOnly Property Item(ByVal index As Integer) As V_BUSINESS_GROUPRow
            Get
                Return CType(Me.Rows(index),V_BUSINESS_GROUPRow)
            End Get
        End Property
        
        Public Event V_BUSINESS_GROUPRowChanging As V_BUSINESS_GROUPRowChangeEventHandler
        
        Public Event V_BUSINESS_GROUPRowChanged As V_BUSINESS_GROUPRowChangeEventHandler
        
        Public Event V_BUSINESS_GROUPRowDeleting As V_BUSINESS_GROUPRowChangeEventHandler
        
        Public Event V_BUSINESS_GROUPRowDeleted As V_BUSINESS_GROUPRowChangeEventHandler
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Overloads Sub AddV_BUSINESS_GROUPRow(ByVal row As V_BUSINESS_GROUPRow)
            Me.Rows.Add(row)
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Overloads Function AddV_BUSINESS_GROUPRow(ByVal sGROUP_NAME As String, ByVal sGROUP_DEALER As String, ByVal STATUS As String, ByVal sBUSINESS_NAME As String, ByVal OPEN_BAL As Decimal) As V_BUSINESS_GROUPRow
            Dim rowV_BUSINESS_GROUPRow As V_BUSINESS_GROUPRow = CType(Me.NewRow,V_BUSINESS_GROUPRow)
            rowV_BUSINESS_GROUPRow.ItemArray = New Object() {Nothing, sGROUP_NAME, sGROUP_DEALER, STATUS, sBUSINESS_NAME, OPEN_BAL}
            Me.Rows.Add(rowV_BUSINESS_GROUPRow)
            Return rowV_BUSINESS_GROUPRow
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function FindBynID(ByVal nID As Decimal) As V_BUSINESS_GROUPRow
            Return CType(Me.Rows.Find(New Object() {nID}),V_BUSINESS_GROUPRow)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Overridable Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Overrides Function Clone() As System.Data.DataTable
            Dim cln As V_BUSINESS_GROUPDataTable = CType(MyBase.Clone,V_BUSINESS_GROUPDataTable)
            cln.InitVars
            Return cln
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Function CreateInstance() As System.Data.DataTable
            Return New V_BUSINESS_GROUPDataTable
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Friend Sub InitVars()
            Me.columnnID = MyBase.Columns("nID")
            Me.columnsGROUP_NAME = MyBase.Columns("sGROUP_NAME")
            Me.columnsGROUP_DEALER = MyBase.Columns("sGROUP_DEALER")
            Me.columnSTATUS = MyBase.Columns("STATUS")
            Me.columnsBUSINESS_NAME = MyBase.Columns("sBUSINESS_NAME")
            Me.columnOPEN_BAL = MyBase.Columns("OPEN_BAL")
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Private Sub InitClass()
            Me.columnnID = New System.Data.DataColumn("nID", GetType(Decimal), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnnID)
            Me.columnsGROUP_NAME = New System.Data.DataColumn("sGROUP_NAME", GetType(String), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnsGROUP_NAME)
            Me.columnsGROUP_DEALER = New System.Data.DataColumn("sGROUP_DEALER", GetType(String), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnsGROUP_DEALER)
            Me.columnSTATUS = New System.Data.DataColumn("STATUS", GetType(String), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnSTATUS)
            Me.columnsBUSINESS_NAME = New System.Data.DataColumn("sBUSINESS_NAME", GetType(String), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnsBUSINESS_NAME)
            Me.columnOPEN_BAL = New System.Data.DataColumn("OPEN_BAL", GetType(Decimal), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnOPEN_BAL)
            Me.Constraints.Add(New System.Data.UniqueConstraint("Constraint1", New System.Data.DataColumn() {Me.columnnID}, true))
            Me.columnnID.AutoIncrement = true
            Me.columnnID.AllowDBNull = false
            Me.columnnID.ReadOnly = true
            Me.columnnID.Unique = true
            Me.columnsGROUP_NAME.MaxLength = 50
            Me.columnsGROUP_DEALER.MaxLength = 50
            Me.columnSTATUS.ReadOnly = true
            Me.columnSTATUS.MaxLength = 3
            Me.columnsBUSINESS_NAME.MaxLength = 50
            Me.columnOPEN_BAL.AllowDBNull = false
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function NewV_BUSINESS_GROUPRow() As V_BUSINESS_GROUPRow
            Return CType(Me.NewRow,V_BUSINESS_GROUPRow)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Function NewRowFromBuilder(ByVal builder As System.Data.DataRowBuilder) As System.Data.DataRow
            Return New V_BUSINESS_GROUPRow(builder)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(V_BUSINESS_GROUPRow)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowChanged(ByVal e As System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.V_BUSINESS_GROUPRowChangedEvent) Is Nothing) Then
                RaiseEvent V_BUSINESS_GROUPRowChanged(Me, New V_BUSINESS_GROUPRowChangeEvent(CType(e.Row,V_BUSINESS_GROUPRow), e.Action))
            End If
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowChanging(ByVal e As System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.V_BUSINESS_GROUPRowChangingEvent) Is Nothing) Then
                RaiseEvent V_BUSINESS_GROUPRowChanging(Me, New V_BUSINESS_GROUPRowChangeEvent(CType(e.Row,V_BUSINESS_GROUPRow), e.Action))
            End If
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowDeleted(ByVal e As System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.V_BUSINESS_GROUPRowDeletedEvent) Is Nothing) Then
                RaiseEvent V_BUSINESS_GROUPRowDeleted(Me, New V_BUSINESS_GROUPRowChangeEvent(CType(e.Row,V_BUSINESS_GROUPRow), e.Action))
            End If
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowDeleting(ByVal e As System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.V_BUSINESS_GROUPRowDeletingEvent) Is Nothing) Then
                RaiseEvent V_BUSINESS_GROUPRowDeleting(Me, New V_BUSINESS_GROUPRowChangeEvent(CType(e.Row,V_BUSINESS_GROUPRow), e.Action))
            End If
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub RemoveV_BUSINESS_GROUPRow(ByVal row As V_BUSINESS_GROUPRow)
            Me.Rows.Remove(row)
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Shared Function GetTypedTableSchema(ByVal xs As System.Xml.Schema.XmlSchemaSet) As System.Xml.Schema.XmlSchemaComplexType
            Dim type As System.Xml.Schema.XmlSchemaComplexType = New System.Xml.Schema.XmlSchemaComplexType
            Dim sequence As System.Xml.Schema.XmlSchemaSequence = New System.Xml.Schema.XmlSchemaSequence
            Dim ds As dsLUP_BUSINESS_GROUP_NEW = New dsLUP_BUSINESS_GROUP_NEW
            xs.Add(ds.GetSchemaSerializable)
            Dim any1 As System.Xml.Schema.XmlSchemaAny = New System.Xml.Schema.XmlSchemaAny
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As System.Xml.Schema.XmlSchemaAny = New System.Xml.Schema.XmlSchemaAny
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As System.Xml.Schema.XmlSchemaAttribute = New System.Xml.Schema.XmlSchemaAttribute
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As System.Xml.Schema.XmlSchemaAttribute = New System.Xml.Schema.XmlSchemaAttribute
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "V_BUSINESS_GROUPDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Return type
        End Function
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")>  _
    Partial Public Class V_BUSINESS_GROUPRow
        Inherits System.Data.DataRow
        
        Private tableV_BUSINESS_GROUP As V_BUSINESS_GROUPDataTable
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Friend Sub New(ByVal rb As System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableV_BUSINESS_GROUP = CType(Me.Table,V_BUSINESS_GROUPDataTable)
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property nID() As Decimal
            Get
                Return CType(Me(Me.tableV_BUSINESS_GROUP.nIDColumn),Decimal)
            End Get
            Set
                Me(Me.tableV_BUSINESS_GROUP.nIDColumn) = value
            End Set
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property sGROUP_NAME() As String
            Get
                Try 
                    Return CType(Me(Me.tableV_BUSINESS_GROUP.sGROUP_NAMEColumn),String)
                Catch e As System.InvalidCastException
                    Throw New System.Data.StrongTypingException("The value for column 'sGROUP_NAME' in table 'V_BUSINESS_GROUP' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableV_BUSINESS_GROUP.sGROUP_NAMEColumn) = value
            End Set
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property sGROUP_DEALER() As String
            Get
                Try 
                    Return CType(Me(Me.tableV_BUSINESS_GROUP.sGROUP_DEALERColumn),String)
                Catch e As System.InvalidCastException
                    Throw New System.Data.StrongTypingException("The value for column 'sGROUP_DEALER' in table 'V_BUSINESS_GROUP' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableV_BUSINESS_GROUP.sGROUP_DEALERColumn) = value
            End Set
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property STATUS() As String
            Get
                Try 
                    Return CType(Me(Me.tableV_BUSINESS_GROUP.STATUSColumn),String)
                Catch e As System.InvalidCastException
                    Throw New System.Data.StrongTypingException("The value for column 'STATUS' in table 'V_BUSINESS_GROUP' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableV_BUSINESS_GROUP.STATUSColumn) = value
            End Set
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property sBUSINESS_NAME() As String
            Get
                Try 
                    Return CType(Me(Me.tableV_BUSINESS_GROUP.sBUSINESS_NAMEColumn),String)
                Catch e As System.InvalidCastException
                    Throw New System.Data.StrongTypingException("The value for column 'sBUSINESS_NAME' in table 'V_BUSINESS_GROUP' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableV_BUSINESS_GROUP.sBUSINESS_NAMEColumn) = value
            End Set
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property OPEN_BAL() As Decimal
            Get
                Return CType(Me(Me.tableV_BUSINESS_GROUP.OPEN_BALColumn),Decimal)
            End Get
            Set
                Me(Me.tableV_BUSINESS_GROUP.OPEN_BALColumn) = value
            End Set
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IssGROUP_NAMENull() As Boolean
            Return Me.IsNull(Me.tableV_BUSINESS_GROUP.sGROUP_NAMEColumn)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SetsGROUP_NAMENull()
            Me(Me.tableV_BUSINESS_GROUP.sGROUP_NAMEColumn) = System.Convert.DBNull
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IssGROUP_DEALERNull() As Boolean
            Return Me.IsNull(Me.tableV_BUSINESS_GROUP.sGROUP_DEALERColumn)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SetsGROUP_DEALERNull()
            Me(Me.tableV_BUSINESS_GROUP.sGROUP_DEALERColumn) = System.Convert.DBNull
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IsSTATUSNull() As Boolean
            Return Me.IsNull(Me.tableV_BUSINESS_GROUP.STATUSColumn)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SetSTATUSNull()
            Me(Me.tableV_BUSINESS_GROUP.STATUSColumn) = System.Convert.DBNull
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IssBUSINESS_NAMENull() As Boolean
            Return Me.IsNull(Me.tableV_BUSINESS_GROUP.sBUSINESS_NAMEColumn)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SetsBUSINESS_NAMENull()
            Me(Me.tableV_BUSINESS_GROUP.sBUSINESS_NAMEColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")>  _
    Public Class V_BUSINESS_GROUPRowChangeEvent
        Inherits System.EventArgs
        
        Private eventRow As V_BUSINESS_GROUPRow
        
        Private eventAction As System.Data.DataRowAction
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub New(ByVal row As V_BUSINESS_GROUPRow, ByVal action As System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property Row() As V_BUSINESS_GROUPRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property Action() As System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class
