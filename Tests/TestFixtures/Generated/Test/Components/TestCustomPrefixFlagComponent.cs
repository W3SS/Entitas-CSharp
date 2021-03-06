//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestContext {

    public TestEntity customPrefixFlagEntity { get { return GetGroup(TestMatcher.CustomPrefixFlag).GetSingleEntity(); } }

    public bool myCustomPrefixFlag {
        get { return customPrefixFlagEntity != null; }
        set {
            var entity = customPrefixFlagEntity;
            if (value != (entity != null)) {
                if (value) {
                    CreateEntity().myCustomPrefixFlag = true;
                } else {
                    entity.Destroy();
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    static readonly CustomPrefixFlagComponent customPrefixFlagComponent = new CustomPrefixFlagComponent();

    public bool myCustomPrefixFlag {
        get { return HasComponent(TestComponentLookup.CustomPrefixFlag); }
        set {
            if (value != myCustomPrefixFlag) {
                var index = TestComponentLookup.CustomPrefixFlag;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : customPrefixFlagComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class TestMatcher {

    static Entitas.IMatcher<TestEntity> _matcherCustomPrefixFlag;

    public static Entitas.IMatcher<TestEntity> CustomPrefixFlag {
        get {
            if (_matcherCustomPrefixFlag == null) {
                var matcher = (Entitas.Matcher<TestEntity>)Entitas.Matcher<TestEntity>.AllOf(TestComponentLookup.CustomPrefixFlag);
                matcher.componentNames = TestComponentLookup.componentNames;
                _matcherCustomPrefixFlag = matcher;
            }

            return _matcherCustomPrefixFlag;
        }
    }
}
