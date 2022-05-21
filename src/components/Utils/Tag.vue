<template>
  
  <div class="input-box">
    <i v-bind:class="icon"></i>
    <Multiselect
      :v-model="value"
      mode="tags"
      :placeholder="placeholder"
      :options="options"
      :searchable="true"
      :createTag="true"
    />
  </div>
</template>

<script lang="ts">
import Multiselect from "@vueform/multiselect";
import { defineComponent } from "vue";
import ITags from "@/interface/ITags";
export default defineComponent({
  // eslint-disable-next-line vue/multi-word-component-names
  name: "Tag",
  emits: ["addingTag"],
  components: { Multiselect },
  props: ["icon", "options", "placeholder"],
  data() {
    return {
      value: [],
    };
  },
  methods: {
    addTag(TagValue: string): void {
      this.$emit("addingTag", {
        descricao: TagValue,
      });
    },
  },
});
</script>
<style lang="scss">
@import url("@/assets/config_sass/tag.scss");
</style>
