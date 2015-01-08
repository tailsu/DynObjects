﻿// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Error List, point to "Suppress Message(s)", and click 
// "In Project Suppression File".
// You do not need to add suppressions to this file manually.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", Target = "Dyn.ITypeAnalysisRule.#Analyze(System.Collections.Generic.List`1<System.Type>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Dyn.Component.#Dyn.IHasObjectHook.Component", Justification = "Component is not meant to be used in a way that makes this suggestion relevant")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Dyn.Component.#Dyn.IObjectHook.SetDynObject(Dyn.DynObject)", Justification = "Component is not meant to be used in a way that makes this suggestion relevant")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Dyn.DynFactory+ObjectMemento", Justification = "ObjectMemento is public only for security reasons. It's not meant to be used by external users.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Dyn.DynObject+MulticastSlotCollection", Justification = "MulticastSlotCollection is a private type used by generated code in user libraries. It's not meant to be used directly by programmers.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member", Target = "Dyn.DynObject.#_ComponentOffsets", Justification = "It's performance-critical to leave this a field as proven by benchmarks.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member", Target = "Dyn.DynObject.#_Components", Justification = "It's performance-critical to leave this a field as proven by benchmarks.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member", Target = "Dyn.DynObject.#_MessageImpl", Justification = "It's performance-critical to leave this a field as proven by benchmarks.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member", Target = "Dyn.DynObject.#_UnicastImpl", Justification = "It's performance-critical to leave this a field as proven by benchmarks.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dyn", Scope = "member", Target = "Dyn.IObjectHook.#OnDynObjectCreated()", Justification = "Dyn is spelled correctly")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dyn", Scope = "member", Target = "Dyn.IObjectHook.#OnDynObjectMutated(System.Collections.Generic.IEnumerable`1<System.Object>,System.Collections.Generic.IEnumerable`1<System.Type>)", Justification = "Dyn is spelled correctly")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dyn", Scope = "member", Target = "Dyn.IObjectHook.#SetDynObject(Dyn.DynObject)", Justification = "Dyn is spelled correctly")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dyn", Scope = "member", Target = "Dyn.Component.#DynObjectCreated", Justification = "Dyn is spelled correctly")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dyn", Scope = "member", Target = "Dyn.Component.#DynObjectMutated", Justification = "Dyn is spelled correctly")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dyn", Scope = "member", Target = "Dyn.Component.#DynThis", Justification = "Dyn is spelled correctly")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dyn", Scope = "type", Target = "Dyn.DynObjectMutatedEventHandler", Justification = "Dyn is spelled correctly")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dyn", Scope = "member", Justification = "Dyn is spelled correctly")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dyn", Scope = "namespace", Target = "Dyn", Justification = "Dyn is spelled correctly")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dyn", Scope = "type", Target = "Dyn.DynException", Justification = "Dyn is spelled correctly")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dyn", Scope = "type", Target = "Dyn.DynFactory", Justification = "Dyn is spelled correctly")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dyn", Scope = "type", Target = "Dyn.DynObject", Justification = "Dyn is spelled correctly")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dyn", Justification = "Dyn is spelled correctly")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dyn", Scope = "type", Target = "Dyn.DynObjectMutatedEventArgs", Justification = "Dyn is spelled correctly")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "dyn", Scope = "member", Target = "Dyn.ComponentProvider.#GetComponentOffsetField(System.Type)", Justification = "Dyn is spelled correctly")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "MinValue", Scope = "member", Target = "Dyn.BidAttribute.#.ctor(System.Int32)", Justification = "Reference to a CLR member")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "Unicast", Scope = "member", Target = "Dyn.TypeInfo.#.ctor(Dyn.DynFactory,System.Type[])", Justification = "Unicast is spelled correctly")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Unicast", Scope = "member", Target = "Dyn.DynObject.#_UnicastImpl", Justification = "Unicast is spelled correctly")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member", Target = "Dyn.DynObject+MulticastSlotCollection.#myComponents", Justification = "The class is an implementation detail. Also, it's performance-critical for this to remain a field.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member", Target = "Dyn.DynObject+MulticastSlotCollection.#myImplementers", Justification = "The class is an implementation detail. Also, it's performance-critical for this to remain a field.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member", Target = "Dyn.DynObject+MulticastSlotIterator.#myComponents", Justification = "The class is an implementation detail. Also, it's performance-critical for this to remain a field.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member", Target = "Dyn.DynObject+MulticastSlotIterator.#myImplementers", Justification = "The class is an implementation detail. Also, it's performance-critical for this to remain a field.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member", Target = "Dyn.DynObject+MulticastSlotIterator.#myPosition", Justification = "The class is an implementation detail. Also, it's performance-critical for this to remain a field.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "objects", Scope = "member", Target = "Dyn.DynFactory.#GetTypes(System.Object[])", Justification = "It's an OK name.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1815:OverrideEqualsAndOperatorEqualsOnValueTypes", Scope = "type", Target = "Dyn.DynFactory+ObjectMemento", Justification = "This class is an implementation detail and won't be used in comparisons.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1815:OverrideEqualsAndOperatorEqualsOnValueTypes", Scope = "type", Target = "Dyn.DynObject+MulticastSlotCollection", Justification = "This class is an implementation detail and won't be used in comparisons.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member", Target = "Dyn.DynFactory+ObjectMemento.#Components", Justification = "This member is part of a class that is an implementation detail.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "member", Target = "Dyn.ComponentProvider.#DefaultMsgImpls", Justification = "Populated by generated code and only used internally, so it's OK.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "member", Target = "Dyn.ComponentProvider.#Types", Justification = "Populated by generated code and only used internally, so it's OK.")]
